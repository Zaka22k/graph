namespace Graph.QuestionBox
{
    public class ShowQuestion
    {
        public static System.Windows.Forms.DialogResult Show()
        {
            System.Windows.Forms.DialogResult dialog = System.Windows.Forms.DialogResult.None;
            using (QuestionBox mesBox = new QuestionBox())
            {
                dialog = mesBox.ShowDialog();
            }
            return dialog;
        }
    }
}
