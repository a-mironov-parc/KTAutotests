using KeepTeamAutotests.Model;
using KeepTeamAutotests.Pages;
using Newtonsoft.Json;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KeepTeamAutotests.AppLogic
{
    public class CommentHelper
    {
        private AppManager app;
        private PageManager pages;

        public CommentHelper(AppManager app)
            
        {
            this.app = app;
            this.pages = app.Pages;
            
        }

  

        public void addComment(Comment comment)
        {
            pages.commentsTab.ensurePageLoaded();
            pages.commentsTab.addComment(comment.message);
        }

        public Comment getComment()
        {
            Comment comment = new Comment();
            comment.message = pages.commentsTab.getMessage();
            return comment;
        }

        public bool CompareComments(Comment C1, Comment C2)
        {
            C1.WriteToConsole();
            C2.WriteToConsole();
            //сравнивает все поля основной информации.
            return C1.message == C2.message
                && C1.author == C2.author;
        }

    }
}
