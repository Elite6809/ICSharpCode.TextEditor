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
	/// <summary>
	/// In this enumeration are all caret modes listed.
	/// </summary>
	public enum CaretMode {
		/// <summary>
		/// If the caret is in insert mode typed characters will be
		/// inserted at the caret position
		/// </summary>
		InsertMode,
		
		/// <summary>
		/// If the caret is in overwirte mode typed characters will
		/// overwrite the character at the caret position
		/// </summary>
		OverwriteMode
	}
}
