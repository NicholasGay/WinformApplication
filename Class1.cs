using System;

public class Class1
{
	public Class1()
	{
	}
    delegate void StringArgReturningVoidDelegate(string text);

    public void UpdateLabel()
	{
        

       
    }

    private void StringArgReturnMethod(string text)
    {
        //Console.WriteLine("txtDisplay_ThreadID-Invoke: " +
        //    Thread.CurrentThread.ManagedThreadId.ToString());
        txtDisplay.AppendText(">>" + text);
        txtDisplay.AppendText("\r\n");

    }
}
