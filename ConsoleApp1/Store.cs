namespace Lab16
{
    internal class Store
    {
        private List<IMemento> _mementos;

        public Store()
        {
            _mementos = new();
        }

        public void Add(IMemento memento)
        {
            if (memento == null) 
            { 
                throw new ArgumentNullException(nameof(memento), "Недопустимое значение"); 
            }

            _mementos.Add(memento);
        }
        
        public IMemento Previous()
        {
            if (_mementos.Count > 0)
            {
                return _mementos[_mementos.Count - 1];
            }
            else
            {
                throw new InvalidOperationException("Список пуст");
            }
        }

        public IMemento GetByDate(DateTime date)
        {
            IMemento? memento = _mementos.FirstOrDefault(m => m.GetDate() == date);

            if (memento != null)
            {
                return memento;
            }
            else
            {
                throw new InvalidOperationException($"Состояние для даты {date} не найдено");
            }
        }
    }
}
