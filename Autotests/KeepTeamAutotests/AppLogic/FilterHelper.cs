using KeepTeamAutotests.Model;
using KeepTeamAutotests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepTeamAutotests.AppLogic
{
    public class FilterHelper
    {
        private AppManager app;
        private PageManager pages;
        public FilterHelper(AppManager app)
        {
            this.app = app;
            this.pages = app.Pages;

        }

    
        public void setFindText( string text)
        {
            pages.filtersPage.ensurePageLoaded();
            pages.filtersPage.setFindFilter(pages.filtersPage.getSearchField(), text);
            pages.filtersPage.ensureUpdateTable();
            
        }
        public void setCheckBoxFilter(int id, string status, string defaultstatus)
        {
            pages.filtersPage.ensurePageLoaded();
            pages.filtersPage.setCheckBoxFilter(pages.filtersPage.byIndex(id), status, defaultstatus);
            pages.filtersPage.ensureUpdateTable();

        }
        public void setCheckBoxFilter(string id, string status, string defaultstatus)
        {
            pages.filtersPage.ensurePageLoaded();
            pages.filtersPage.setCheckBoxFilter(pages.filtersPage.byText(id), status, defaultstatus);
            pages.filtersPage.ensureUpdateTable();

        }
        public void ClearFilters()
        {
            pages.filtersPage.ensurePageLoaded();
            pages.filtersPage.clearClick();
            pages.filtersPage.ensureUpdateTable();
            
        }
        public void ClearSearchField()
        {
            pages.filtersPage.ensurePageLoaded();
            pages.filtersPage.clearSearchField();
            pages.filtersPage.ensureUpdateTable();

        }

    }
}
