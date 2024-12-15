namespace Graph.ErrorBox
{
    public class ShowError
    {
        public static System.Windows.Forms.DialogResult Show(string message)
        {
            System.Windows.Forms.DialogResult dialog = System.Windows.Forms.DialogResult.None;
            using (ErrorBox mesBox = new ErrorBox())
            {
                mesBox.Data = message;
                dialog = mesBox.ShowDialog();
            }
            return dialog;
        }
    }
}
