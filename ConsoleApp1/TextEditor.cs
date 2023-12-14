namespace Lab16
{
    internal class TextEditor
    {
        private string _text;

        public TextEditor()
        {
            _text = string.Empty;
        }

        public TextEditor(IMemento memento)
        {
            if (memento is TextEditorMemento texEditorMemento)
            {
                _text = texEditorMemento.GetState();
            }
            else
            {
                throw new ArgumentException(nameof(memento), "Недопустимое значение");
            }
        }

        public string GetState()
        {
            return _text;
        }

        public IMemento CreateMemento()
        {
            return new TextEditorMemento(_text);
        }
    }
}
