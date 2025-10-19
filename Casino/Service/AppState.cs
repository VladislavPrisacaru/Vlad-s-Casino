using System;

namespace Casino.Service
{
    public class AppState
    {
        private int _coins = 100;
        public int Coins
        {
            get => _coins;
            set
            {
                if (_coins != value)
                {
                    _coins = value;
                    NotifyStateChanged();
                }
            }
        }

        private int _chips = 100;
        public int Chips
        {
            get => _chips;
            set
            {
                if (_chips != value)
                {
                    _chips = value;
                    NotifyStateChanged();
                }
            }
        }

        public event Action? OnChange;

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
