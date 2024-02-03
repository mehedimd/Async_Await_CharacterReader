namespace CharacterReader_Async_Await
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int CountCharacter()
        {
            int count = 0;
            using (StreamReader reader = new StreamReader("C:\\MEHEDI C#\\02-02-24\\CharacterReader_Async_Await\\Data.txt"))
            {
                string content = reader.ReadToEnd();
                count = content.Length;

                Thread.Sleep(5000);    
            }
            return count;
        }

        private async void btnProcessFile_Click(object sender, EventArgs e)
        {
            Task<int> task = new Task<int>(CountCharacter);
            task.Start();
            lblBtn.Text = "File Processing. Please wait...";
            int count = await task;
            lblBtn.Text = count.ToString() + " Character of Code Total.";
        }
    }
}
