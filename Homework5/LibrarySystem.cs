// Written by Andre
// 2/27/25

namespace Homework5;

// {{{ Parent Class Book
public class Book {
	public string Title         {get;set;}
	public string Author        {get;set;}
	public int    YearPublished {get;set;}

	public Book(string pTitle, string pAuthor, int pYearPublished) {
		this.Title         = pTitle;
		this.Author        = pAuthor;
		this.YearPublished = pYearPublished;
	}

	public override string ToString() {
		return $"{this.Title} by {this.Author} ({this.YearPublished})";
	}
}
// }}} Parent Class Book

// {{{ Child Classes EBook, PrintedBook of Book
public class EBook : Book {
	public int FileSizeMB {get;set;}

	public EBook(string pTitle, string pAuthor, int pYearPublished, int pFileSizeMB) : base(pTitle, pAuthor, pYearPublished) {
		this.FileSizeMB = pFileSizeMB;
	}

	public override string ToString() {
		return $"{this.Title} by {this.Author} ({this.YearPublished}) {this.FileSizeMB}MB";
	}
}

public class PhysicalBook : Book {
	public int PageCount {get;set;}

	public PhysicalBook(string pTitle, string pAuthor, int pYearPublished, int pPageCount) : base(pTitle, pAuthor, pYearPublished) {
		this.PageCount = pPageCount;
	}

	public override string ToString() {
		return $"{this.Title} by {this.Author} ({this.YearPublished}) {this.PageCount} pages";
	}
}
/// }}} Child Classes EBook, PrintedBook of Book
