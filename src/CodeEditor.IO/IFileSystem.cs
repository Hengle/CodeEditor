using System.Collections.Generic;
using System.IO;

namespace CodeEditor.IO
{
	public interface IFileSystem
	{
		IFile FileFor(string file);
		IFolder FolderFor(string folder);
	}

	public interface IFile
	{
		/// <summary>
		/// File extension including the ".".
		/// </summary>
		string Extension { get; }
		string ReadAllText();
		void WriteAllText(string text);
	}

	public interface IFolder
	{
		IEnumerable<IFile> GetFiles(string pattern, SearchOption searchOption);
	}
}
