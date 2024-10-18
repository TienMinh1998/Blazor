namespace THFontEnd.StateObjects
{
    public class LoginState
    {
        private bool IsUserLogin  = false;

        public void SetState(bool loginStatus)
        {
            this.IsUserLogin  = loginStatus;
            NotifyStateChanged();
        }

        public bool GetSate()
        {
            return IsUserLogin;
        }

        // EVENT

        public event Action OnChange;
        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
