using System;
using System.Windows.Forms;

namespace SimpleWindowsFormsApp
{
    public partial class Form1 : Form
    {
        // Создаем элементы управления
        private Button button;
        private TextBox textBox;
        private Label label;

        public Form1()
        {
            InitializeComponent();
            
            // Инициализация компонентов
            button = new Button();
            textBox = new TextBox();
            label = new Label();

            // Настройка кнопки
            button.Text = "Показать текст";
            button.Location = new System.Drawing.Point(100, 100);
            button.Click += new EventHandler(Button_Click);

            // Настройка текстового поля
            textBox.Location = new System.Drawing.Point(100, 50);
            textBox.Width = 200;

            // Настройка метки
            label.Text = "Здесь будет ваш текст";
            label.Location = new System.Drawing.Point(100, 150);
            label.Width = 200;

            // Добавление элементов на форму
            Controls.Add(button);
            Controls.Add(textBox);
            Controls.Add(label);
        }

        // Обработчик нажатия на кнопку
        private void Button_Click(object sender, EventArgs e)
        {
            label.Text = textBox.Text;
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
