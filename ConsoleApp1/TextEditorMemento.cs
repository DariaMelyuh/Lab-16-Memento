namespace Lab16
{
    internal class TextEditorMemento : IMemento
    {
        private string _text;
        private DateTime _date;

        public TextEditorMemento(string text)
        {
            if (text == null) 
            { 
                throw new ArgumentNullException(nameof(text), "Недопустимое значение"); 
            }

            _text = text;
            _date = DateTime.Now;
        }

        public string GetState()
        {
            return _text;
        }

        public DateTime GetDate()
        {
            return _date;
        }
    }
}
