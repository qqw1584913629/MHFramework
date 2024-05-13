public interface IAUIEventHandler
{
    void OnInitWindowCoreData(BasePanel basePanel);
    /// <summary>
    /// 注册UI业务逻辑事件
    /// </summary>
    /// <param name="basePanel"></param>
    void OnRegisterUIEvent(BasePanel basePanel);

    /// <summary>
    /// 打开UI窗口的业务逻辑
    /// </summary>
    /// <param name="basePanel"></param>
    /// <param name="contextData"></param>
    void OnShowWindow(BasePanel basePanel, object contextData = null);
        
    /// <summary>
    /// 隐藏UI窗口的业务逻辑
    /// </summary>
    /// <param name="basePanel"></param>
    void OnHideWindow(BasePanel basePanel);

    /// <summary>
    /// 完全关闭销毁UI窗口之前的业务逻辑，用于完全释放UI相关对象
    /// </summary>
    /// <param name="basePanel"></param>
    void BeforeUnload(BasePanel basePanel);
}