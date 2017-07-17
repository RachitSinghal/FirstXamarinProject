package md5780634bd3d0c61a36889b53970253617;


public class ActivitySpl
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("Trails.Droid.ActivitySpl, Trails.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ActivitySpl.class, __md_methods);
	}


	public ActivitySpl () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ActivitySpl.class)
			mono.android.TypeManager.Activate ("Trails.Droid.ActivitySpl, Trails.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
