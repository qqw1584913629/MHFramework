package com.unity3d.player;

import android.app.Activity;
import android.app.AlertDialog;
import android.content.DialogInterface;
import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.webkit.WebView;
 
public class PrivacyActivity extends Activity implements DialogInterface.OnClickListener {
  
  // 隐私协议内容
//   final String privacyContext =
//   "欢迎使用本游戏，在使用本游戏前，请您充分阅读并理解<a href='https://www.yuque.com/zhengyihang-hruh5/rhregt/ghy9d5k4rk1fb78v?singleDoc#《用户服务协议》'>《用户协议》</a>和<a href='https://www.yuque.com/zhengyihang-hruh5/rhregt/iwo3gga2pdfc3ozp?singleDoc#《隐私协议》'>《隐私政策》</a>各条;\n1.保护用户隐私是本游戏的一项基本政策，本游戏不会泄露您的个人信息；\n2.我们会根据您使用的具体功能需要，收集必要的用户信息（如申请设备信息，存储等相关权限）；\n3.在您同意App隐私政策后，我们将进行集成SDK的初始化工作，会收集您的android_id、Mac地址、IMEI和应用安装列表，以保障App正常数据统计和安全风控；\n4.为了方便您的查阅，您可以通过“设置”重新查看该协议；\n5.您可以阅读完整版的隐私保护政策了解我们申请使用相关权限的情况，以及对您个人隐私的保护措施。";
     
   // 隐私协议内容
   final String privacyContext =
   "欢迎使用本游戏，在使用本游戏前，请您充分阅读并理解 <a href=\"https://www.yuque.com/zhengyihang-hruh5/rhregt/ghy9d5k4rk1fb78v\">《用户协议》</a>和" +
   "<a href=\"https://www.yuque.com/zhengyihang-hruh5/rhregt/iwo3gga2pdfc3ozp\">《隐私政策》</a>各条;\n" +
   "1.保护用户隐私是本游戏的一项基本政策，本游戏不会泄露您的个人信息；\n" +
   "2.我们会根据您使用的具体功能需要，收集必要的用户信息（如申请设备信息，存储等相关权限）；\n" +
   "3.在您同意App隐私政策后，我们将进行集成SDK的初始化工作，会收集您的android_id、Mac地址、IMEI和应用安装列表，以保障App正常数据统计和安全风控；\n" +
   "4.第三方SDK收集信息以及用处：Tap SDK应用场景：游戏登录、数据分析、实时语音、防沉迷、内嵌动态、游戏好友、正版验证。" +
   "可能收集的个人信息的类型：读写存储权限、读取电话状态、IMSI、网络设备制造商、GAID、android ID、bssid 设备应用列表、WiFi 信息、设备版本、手机样式、系统版本、任务列表、录音、传感器信息"+
   "第三方SDK提供方：易玩（上海）网络科技有限公司 <a href=\"https://developer.taptap.com/docs/sdk/start/agreement/\">《TapSDK隐私政策链接》</a>\n" +
   "5.为了方便您的查阅，您可以通过“设置”重新查看该协议；\n" +
   "6.您可以阅读完整版的隐私保护政策了解我们申请使用相关权限的情况，以及对您个人隐私的保护措施。";
    
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
  
        // 如果已经同意过隐私协议则直接进入Unity Activity
        if (GetPrivacyAccept()){
            EnterUnityActivity();
            return;
        }
        // 弹出隐私协议对话框
        ShowPrivacyDialog();
    }
 
    // 显示隐私协议对话框
    private void ShowPrivacyDialog(){
        WebView webView = new WebView(this);
        webView.loadData(privacyContext, "text/html", "utf-8");         
        AlertDialog.Builder privacyDialog = new AlertDialog.Builder(this);
        privacyDialog.setCancelable(false);
        privacyDialog.setView(webView);
        privacyDialog.setTitle("提示");
        privacyDialog.setNegativeButton("拒绝",this);
        privacyDialog.setPositiveButton("同意",this);
        privacyDialog.create().show();
    }
    
    @Override
    public void onClick(DialogInterface dialogInterface, int i) {
        switch (i){
            case AlertDialog.BUTTON_POSITIVE://点击同意按钮
                SetPrivacyAccept(true);
                EnterUnityActivity(); //启动Unity Activity
                break;
            case AlertDialog.BUTTON_NEGATIVE://点击拒绝按钮,直接退出App
                SetPrivacyAccept(true);
                finish();
                break;
        }
    }
    
    // 启动Unity Activity
    private void EnterUnityActivity(){
        Intent unityAct = new Intent();
        unityAct.setClassName(this, "com.unity3d.player.UnityPlayerActivity");
        this.startActivity(unityAct);
    }
    
    // 本地存储保存同意隐私协议状态
    private void SetPrivacyAccept(boolean accepted){
        SharedPreferences.Editor prefs = this.getSharedPreferences("PlayerPrefs", MODE_PRIVATE).edit();
        prefs.putBoolean("PrivacyAcceptedKey", accepted);
        prefs.apply();
    }
    
    // 获取是否已经同意过
    private boolean GetPrivacyAccept(){
        SharedPreferences prefs = this.getSharedPreferences("PlayerPrefs", MODE_PRIVATE);
        return prefs.getBoolean("PrivacyAcceptedKey", false);
    }
}
