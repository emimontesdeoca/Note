﻿using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Note.Site.Models
{
    public class CascadeData
    {
        #region UserData

        #endregion

        public User User { get; set; }
        public Settings Settings { get; set; }
        public List<Book> Books { get; set; }
        public History History { get; set; }

        private Book selectedBook;
        public Book SelectedBook
        {
            get
            {
                if (History.SelectedBookId == default)
                {
                    return default;
                }
                else
                {
                    selectedBook = Books.ToList().SingleOrDefault(x => x.Id == History.SelectedBookId);
                    return selectedBook;
                }
            }
            set => selectedBook = value;
        }
        public Page SelectedPage
        {
            get
            {
                return SelectedBook == null ? default : SelectedBook.Pages.SingleOrDefault(x => x.Id == History.SelectedPageId);
            }
            set => SelectedPage = value;
        }

        #region Callback
        public Action Callback { get; set; }

        #endregion

        #region Saving

        public bool SaveNeeded { get; set; }

        #endregion


    }
}
