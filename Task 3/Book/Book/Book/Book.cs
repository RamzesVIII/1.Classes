﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public class Book
    {
        readonly Author author;
        readonly Title title;
        readonly Content content;

        public Book(string author, string title, string content)
        {
            this.author = new Author(author);
            this.title = new Title(title);
            this.content = new Content(content);
        }

        public void ShowAll()
        {
            author.Show();
            title.Show();
            content.Show();
        }
    }
}
