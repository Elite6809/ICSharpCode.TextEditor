// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="Mike Krüger" email="mike@icsharpcode.net"/>
//     <version>$Revision$</version>
// </file>

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.Runtime.InteropServices;

using ICSharpCode.TextEditor.Document;

namespace ICSharpCode.TextEditor
{
    public partial class Caret : System.IDisposable
    {
#if WINDOWS            
		class Win32Caret : CaretImplementation
		{
			[DllImport("User32.dll")]
			static extern bool CreateCaret(IntPtr hWnd, int hBitmap, int nWidth, int nHeight);
			
			[DllImport("User32.dll")]
			static extern bool SetCaretPos(int x, int y);
			
			[DllImport("User32.dll")]
			static extern bool DestroyCaret();
			
			[DllImport("User32.dll")]
			static extern bool ShowCaret(IntPtr hWnd);
			
			[DllImport("User32.dll")]
			static extern bool HideCaret(IntPtr hWnd);
			
			TextArea textArea;
			
			public Win32Caret(Caret caret)
			{
				this.textArea = caret.textArea;
			}
			
			public override bool Create(int width, int height)
			{
				return CreateCaret(textArea.Handle, 0, width, height);
			}
			public override void Hide()
			{
				HideCaret(textArea.Handle);
			}
			public override void Show()
			{
				ShowCaret(textArea.Handle);
			}
			public override bool SetPosition(int x, int y)
			{
				return SetCaretPos(x, y);
			}
			public override void PaintCaret(Graphics g)
			{
			}
			public override void Destroy()
			{
				DestroyCaret();
			}
		}
#endif
	}
}
