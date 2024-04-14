namespace Helper
{
    public static class TipsHelper
    {
        public static void ShowTipsInfo(string content)
        {
            UIManager.Instance.ShowWindow(WindowID.WindowID_Tips);
            UIManager.Instance.GetUILogic<DlgTipsSystem>(WindowID.WindowID_Tips).SetContent(content);
        }
    }
}