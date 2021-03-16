using System.ComponentModel;
using System.Runtime.CompilerServices;
using ValueLiblary.Annotations;

namespace ValueLiblary
{
    public class PropertyChange : INotifyPropertyChanged
    {
        private dynamic _context
        {
            get { return _context1; }
            set
            {
                if(_context1==value) return;
                _context1 = value;
                OnPropertyChanged(nameof(_context));
            }
        }

        private PropertyChangingDelegate evnt;
        private dynamic _context1;
        public event PropertyChangedEventHandler PropertyChanged;

        public PropertyChange(ref dynamic value, PropertyChangingDelegate eventDelegate)
        {
            _context1 = value;
            evnt = eventDelegate;
        }
        public PropertyChange(ref string value, PropertyChangingDelegate eventDelegate) 
        {
            _context1 = value;
            var __t = value.GetType().GetMember("");
            evnt = eventDelegate;

        }
        public PropertyChange(ref int value, PropertyChangingDelegate eventDelegate)
        {
            _context1 = value;
            evnt = eventDelegate;
        }
        public PropertyChange(ref long value, PropertyChangingDelegate eventDelegate)
        {
            _context1 = value;
            evnt = eventDelegate;
        }


        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            evnt?.Invoke(this);
        }


    }
}
