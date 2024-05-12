using System.ComponentModel;
using System.Net;
using System.Reflection;

namespace HomeWork3_6_2;

public class Book {

    private int lastFoundIndexPage = -1; // zero based
    private int lastFoundIndexLine = -1;
    private int lastFoundIndexInLine = -1;
    private string lastSearchWord = string.Empty;

    public string Title { get; private set; }

    // 0 | 1 | 1
    // 0 | 1 | -1

    /*erere4343
     * ABC
     *kkh
     * llhh
     * ----
     * jjg
     * huh jB
     */

    public Page[] Pages {  get; private set; }

    public Book(string title, params Page[] pages) {
        Pages = pages;
        Title = title;
    }

    public bool FindNext(string str) {
        if (str != lastSearchWord) {
            lastFoundIndexInLine = -1;
            lastFoundIndexLine = -1;
            lastFoundIndexPage = -1;
            lastSearchWord = str;
        }

        for (int pageNo = (lastFoundIndexPage == -1 ? 0 : lastFoundIndexPage); pageNo < Pages.Length; pageNo++) {
            var page = Pages[pageNo];
            string[] lines = page.Content.Split('\n');

            for (int lineNo = (lastFoundIndexLine == -1 ? 0 : lastFoundIndexLine); lineNo < lines.Length; lineNo++) {
                var line = lines[lineNo];
                var i = line.IndexOf(str, lastFoundIndexInLine + 1);
                if (i >= 0) {
                    lastFoundIndexPage = pageNo;
                    lastFoundIndexLine = lineNo;
                    lastFoundIndexInLine = i;
                    
                    Console.WriteLine($"Слово '{str}' знайдено на сторінці #{pageNo + 1}, рядок #{lineNo + 1}, позиція {i + 1}");

                    return true;
                } else {
                    lastFoundIndexInLine = -1;
                }
            }
            lastFoundIndexLine = -1;
        }
        lastFoundIndexPage = -1;

        return false;
    }
}
