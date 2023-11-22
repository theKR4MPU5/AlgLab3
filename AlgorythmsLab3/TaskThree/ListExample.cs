using System;
using System.Collections.Generic;


class PlaylistNode
{
    public string Title { get; set; }
    public string Artist { get; set; }
    public string FilePath { get; set; }
    public PlaylistNode Next { get; set; }

    public PlaylistNode(string title, string artist, string filePath)
    {
        Title = title;
        Artist = artist;
        FilePath = filePath;
        Next = null;
    }
}


class Playlist
{
    private PlaylistNode head;

    public void AddSong(string title, string artist, string filePath)
    {
        PlaylistNode newNode = new PlaylistNode(title, artist, filePath);

        if (head == null)
        {
            head = newNode;
        }
        else
        {
            PlaylistNode current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    public void DisplayPlaylist()
    {
        PlaylistNode current = head;
        while (current != null)
        {
            Console.WriteLine($"Title: {current.Title}, Artist: {current.Artist}, FilePath: {current.FilePath}");
            current = current.Next;
        }
    }
}
