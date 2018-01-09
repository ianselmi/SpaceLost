namespace SpaceLost.Win.UI
{
    public class ListItem
    {
        private object _value;

        public object Value
        {
            get { return _value; }
            set { _value = value; }
        }

        private string _text;

        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        public ListItem(string text, object value)
        {
            _value = value;
            _text = text;
        }

        public override string ToString()
        {
            return _text;
        }
    }
}