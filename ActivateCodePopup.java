//
// Decompiled by Jadx (Fallback) - 1279ms
//
package com.one.chatgpt.user.ui.popup;

public class ActivateCodePopup extends com.lxj.xpopup.core.BottomPopupView {
    @butterknife.BindView(0x7f0a0061)
    androidx.appcompat.widget.AppCompatEditText activeCodeEdit;
    private butterknife.Unbinder mUnbinder;
    @butterknife.BindView(0x7f0a043c)
    android.view.View root;
    java.lang.Runnable successRunnable;

    static {
            r0 = 1525(0x5f5, float:2.137E-42)
            com.nmmedit.protect.NativeUtil.classes3Init0(r0)
            return
    }

    public ActivateCodePopup(android.content.Context r1, java.lang.Runnable r2) {
            r0 = this;
            r0.<init>(r1)
            r0.successRunnable = r2
            return
    }

    private native void initView();

    static void lambda$active$1(com.lxj.xpopup.core.BasePopupView r0, java.lang.Throwable r1) throws java.lang.Throwable {
            boolean r1 = r0.isShow()
            if (r1 == 0) goto L9
            r0.dismiss()
        L9:
            java.lang.String r0 = "激活失败"
            com.hjq.toast.ToastUtils.show(r0)
            return
    }

    @butterknife.OnClick({2131361888})
    public native void active();

    protected native int getImplLayoutId();

    public void lambda$active$0$com-one-chatgpt-user-ui-popup-ActivateCodePopup(com.lxj.xpopup.core.BasePopupView r2, com.one.chatgpt.user.http.Response r3) throws java.lang.Throwable {
            r1 = this;
            boolean r0 = r2.isShow()
            if (r0 == 0) goto L9
            r2.dismiss()
        L9:
            int r2 = r3.getCode()
            r0 = 200(0xc8, float:2.8E-43)
            if (r2 != r0) goto L38
            java.lang.Runnable r2 = r1.successRunnable
            if (r2 == 0) goto L18
            r2.run()
        L18:
            com.google.android.material.dialog.MaterialAlertDialogBuilder r2 = new com.google.android.material.dialog.MaterialAlertDialogBuilder
            android.content.Context r3 = r1.getContext()
            r2.<init>(r3)
            java.lang.String r3 = "激活成功"
            com.google.android.material.dialog.MaterialAlertDialogBuilder r2 = r2.setTitle(r3)
            java.lang.String r3 = "恭喜您已成功激活会员"
            com.google.android.material.dialog.MaterialAlertDialogBuilder r2 = r2.setMessage(r3)
            r3 = 0
            java.lang.String r0 = "确定"
            com.google.android.material.dialog.MaterialAlertDialogBuilder r2 = r2.setPositiveButton(r0, r3)
            r2.show()
            goto L3f
        L38:
            java.lang.String r2 = r3.getMsg()
            com.hjq.toast.ToastUtils.show(r2)
        L3f:
            return
    }

    protected native void onCreate();

    public native void onDestroy();
}
