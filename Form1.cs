using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack; // Для парсингу HTML

namespace TextEditor
{
    public partial class Text_Editor : Form
    {
        private HtmlAgilityPack.HtmlDocument _doc; // Змінна класу для зберігання HTML-документа
        private int _currentPage = 0; // Змінна для зберігання поточного значення параметра start

        private EventLogger eventLogger_ = EventLogger.Instance;

        public Text_Editor()
        {
            InitializeComponent();
            this.Text = "Text Editor";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string extension = Path.GetExtension(filePath);

                IDocumentFactory factory = new DocumentFactoryLoader();

                try
                {
                    IDocumentLoader loader = factory.CreateDocumentLoader(extension);
                    string content = loader.Load(filePath);
                    string processedContent = loader.ProcessContent(content);

                    inputRichTextBox.Text = processedContent;
                }
                catch (NotSupportedException ex)
                {
                    MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "HTML Files (*.html)|*.html|Text Files (*.txt)|*.txt|Binary Files (*.bin)|*.bin|All Files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string textToSave = inputRichTextBox.Text;
                string filePath = saveFileDialog.FileName;
                int selectedFormat = saveFileDialog.FilterIndex;

                DocumentFactory factory;
                switch (selectedFormat)
                {
                    case 1:
                        factory = new HtmlDocumentFactory();
                        break;
                    case 2:
                        factory = new TxtDocumentFactory();
                        break;
                    case 3:
                        factory = new BinaryDocumentFactory();
                        break;
                    default:
                        MessageBox.Show("Невідомий формат файлу.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                Document document = factory.CreateDocument(textToSave);
                document.Save(filePath);
            }
        }

        private void removeSpacesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = inputRichTextBox.Text;
            string trimmedText = Regex.Replace(text, @"\s+", " ");
            outputRichTextBox.Text = trimmedText;
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = inputRichTextBox.Text; // Отримуємо текст з першого richTextBox 
            int characters = text.Length;
            int fileSizeBytes = Encoding.Unicode.GetByteCount(text); // Розмір файлу в байтах 
            int fileSizeKB = fileSizeBytes / 1024; // Розмір файлу в кілобайтах 
            int paragraphs = text.Split(new string[] { "\n\n" }, StringSplitOptions.None).Length;
            int blankLines = text.Split('\n').Count(line => String.IsNullOrWhiteSpace(line));
            int authorPages = characters / 1800;
            int vowels = text.Count(c => "aeiouAEIOUаеёиоуыэюяАЕЁИОУЫЭЮЯ".Contains(c));
            int consonants = text.Count(c => "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZбвгджзйклмнпрстфхцчшщБВГДЖЗЙКЛМНПРСТФХЦЧШЩ".Contains(c));
            int digits = text.Count(c => char.IsDigit(c));
            int specialCharacters = text.Count(c => !char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c));
            int punctuationMarks = text.Count(c => char.IsPunctuation(c));
            int cyrillicLetters = text.Count(c => '\u0400' <= c && c <= '\u04FF');
            int latinLetters = text.Count(c => ('a' <= c && c <= 'z') || ('A' <= c && c <= 'Z'));

            MessageBox.Show($"File size: {fileSizeBytes} bytes\n" +
                            $"File size: {fileSizeKB} KB\n" +
                            $"Characters: {characters}\n" +
                            $"Paragraphs: {paragraphs}\n" +
                            $"Blank lines: {blankLines}\n" +
                            $"Author pages: {authorPages}\n" +
                            $"Vowels: {vowels}\n" +
                            $"Consonants: {consonants}\n" +
                            $"Digits: {digits}\n" +
                            $"Special characters: {specialCharacters}\n" +
                            $"Punctuation marks: {punctuationMarks}\n" +
                            $"Cyrillic letters: {cyrillicLetters}\n" +
                            $"Latin letters: {latinLetters}",
                            "Statistics");
        }

        private void findSurnameWithInitialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = inputRichTextBox.Text;
            Regex regex = new Regex(@"\b[A-Z][a-z]*\s[A-Z]\.\s?[A-Z]\.?"); // Для англійських ініціалів 
            Match match = regex.Match(text);
            if (match.Success)
            {
                MessageBox.Show($"Found: {match.Value}",
                    "Search");
            }
            else
            {
                regex = new Regex(@"\b[А-ЯЁЄЇІ][а-яёєїі]*\s[А-ЯЁЄЇІ]\.\s?[А-ЯЁЄЇІ]\.?");
                match = regex.Match(text);
                if (match.Success)
                {
                    MessageBox.Show($"Found: {match.Value}",
                        "Search");
                }
                else
                {
                    MessageBox.Show("No matches found",
                        "Search");
                }
            }
        }


        private void countWordOccurrencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = inputRichTextBox.Text;
            Dictionary<string, int> wordCounts = new Dictionary<string, int>();
            string[] words = text.Split(new[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)
            {
                if (wordCounts.ContainsKey(word))
                {
                    wordCounts[word]++;
                }
                else
                {
                    wordCounts[word] = 1;
                }
            }

            string message = string.Join("\n", wordCounts.Select(kvp => $"{kvp.Key}: {kvp.Value}"));
            MessageBox.Show(message, "Word Occurrences");
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Open: Opens a file and displays its content in the text box.\n\n" +
                "Save: Saves the content of the text box to a file.\n\n" +
                "Remove Spaces: Removes extra spaces from the text.\n\n" +
                "Statistics: Displays statistics about the text.\n\n" +
                "Find Surname With Initials: Finds the first occurrence of a surname with initials in the text.\n\n" +
                "Count Word Occurrences: Counts the number of occurrences of each word in the text.\n\n" +
                "Help: Displays this help message.",
                "Help"
            );
        }

        // Функція для завантаження новин
        private void LoadNews()
        {
            // Отримання кількості новин з TextBox
            int newsCount;

            // Спроба перетворення введеного тексту на число
            try
            {
                newsCount = int.Parse(newsCountTextBox.Text);
            }
            catch (FormatException)
            {
                // Помилка: користувач ввів текст замість цифр
                MessageBox.Show("Будь ласка, введіть число.", "Warning");
                return; // Вихід з функції
            }

            try
            {
                // Виконання запиту до веб-сайту
                string url = $"https://www.znu.edu.ua/cms/index.php?action=news/view&start={_currentPage}&site_id=27&lang=ukr"; // Додаємо параметр start до URL-адреси
                var webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8; // Встановлення кодування
                string html = webClient.DownloadString(url);

                // Парсинг HTML-сторінки за допомогою HtmlAgilityPack
                _doc = new HtmlAgilityPack.HtmlDocument(); // Зберігаємо HTML-документ у змінній класу
                _doc.LoadHtml(html);

                // Вибір елементів новин
                var newsItems = _doc.DocumentNode.SelectNodes("//div[@class='znu-2016-new']").ToList();

                // Обмеження кількості новин
                newsItems = newsItems.Take(newsCount).ToList();

                // Очищення ListBox
                newsListBox.Items.Clear();

                // Додавання заголовків новин до ListBox
                foreach (var newsItem in newsItems)
                {
                    string title = newsItem.SelectSingleNode(".//h4").InnerText.Trim();
                    newsListBox.Items.Add(title);
                }
            }
            catch (WebException ex)
            {
                // Обробка помилки віддаленого сервера
                MessageBox.Show($"Помилка при завантаженні новин: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Функція для відображення тексту анотації
        private void DisplayAnnotation()
        {
            if (newsListBox.SelectedItem == null)
            {
                return; // Вихід з функції, якщо нічого не вибрано
            }

            // Отримання вибраного заголовка
            string selectedTitle = newsListBox.SelectedItem.ToString();

            // Пошук новини з вибраним заголовком
            var newsItem = _doc.DocumentNode.SelectNodes("//div[@class='znu-2016-new']")
                .FirstOrDefault(item => item.SelectSingleNode(".//h4").InnerText.Trim() == selectedTitle);

            // Отримання тексту анотації
            string annotationText = "";
            if (newsItem != null)
            {
                var annotationNode = newsItem.SelectSingleNode(".//div[@class='text']");
                if (annotationNode != null)
                {
                    annotationText = annotationNode.InnerText.Trim();
                }
            }

            // Відображення тексту анотації
            outputRichTextBox.Text = annotationText;
        }

        // Обробник події натискання кнопки "Завантажити новини"
        private void loadNewsButton_Click(object sender, EventArgs e)
        {
            _currentPage = 0; // Скидаємо поточну сторінку
            LoadNews();
        }

        // Обробник події вибору елемента в ListBox
        private void newsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayAnnotation();
        }

        // Обробник події натискання кнопки "Наступна сторінка"
        private void nextPageButton_Click(object sender, EventArgs e)
        {
            _currentPage++; // Збільшуємо значення start на 1
            LoadNews();
        }

        // Обробник події натискання кнопки "Попередня сторінка"
        private void previousPageButton_Click(object sender, EventArgs e)
        {
            _currentPage--; // Зменшуємо значення start на 1
            if (_currentPage < 0)
            {
                _currentPage = 0; // Не дозволяємо перейти на сторінку з від'ємним номером
            }
            LoadNews();
        }

        private void inputRichTextBox_TextChanged(object sender, EventArgs e)
        {
            // Отримання позиції курсора
            int lineNumber = inputRichTextBox.GetLineFromCharIndex(inputRichTextBox.SelectionStart) + 1;
            int columnNumber = inputRichTextBox.SelectionStart - inputRichTextBox.GetFirstCharIndexOfCurrentLine() + 1;

            // Протоколювання події
            eventLogger_.LogEvent("Зміна тексту", lineNumber, columnNumber, inputRichTextBox.Text);
        }
    }

public class EventLogger
    {
        private static EventLogger instance_;
        private readonly string logFilePath_ = "D:\\Event_log\\events.log"; // Шлях до файлу журналу

        private EventLogger()
        {
            // Перевіряємо, чи файл журналу існує, та створюємо його, якщо ні
            if (!File.Exists(logFilePath_))
            {
                File.Create(logFilePath_).Close();
            }
        }

        public static EventLogger Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new EventLogger();
                }
                return instance_;
            }
        }

        public void LogEvent(string eventType, int lineNumber, int columnNumber, string text)
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string logEntry = $"{timestamp} [{eventType}] ({lineNumber},{columnNumber}): {text}";
            File.AppendAllText(logFilePath_, logEntry + Environment.NewLine);
        }
    }
}