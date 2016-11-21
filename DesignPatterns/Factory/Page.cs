using System.Collections.Generic;

namespace Factory
{
    public abstract class Page
    {
        
    }

    public class Skillspage : Page
    {
        
    }

    public class EducationPage : Page
    {
        
    }

    public class ExperiencePage : Page
    {
        
    }

    public class IntroductionPage : Page
    {
        
    }

    public class ResultsPage : Page
    {
        
    }

    public class ConclusionPage : Page
    {
        
    }

    public class SummaryPage : Page
    {
        
    }

    public class BibilographyPage : Page
    {
        
    }

    public abstract class Document
    {
        private List<Page> _pages = new List<Page>();

        protected Document()
        {
            this.CeatePages();
        }

        public List<Page> Pages
        {
            get { return _pages; }
        }

        public abstract void CeatePages();
    }

    public class Resume : Document
    {
        public override void CeatePages()
        {
            Pages.Add(new Skillspage());
            Pages.Add(new EducationPage());
            Pages.Add(new ExperiencePage());
        }
    }

    public class Report : Document
    {
        public override void CeatePages()
        {
           Pages.Add(new IntroductionPage());
            Pages.Add(new ResultsPage());
            Pages.Add(new ConclusionPage());
            Pages.Add(new SummaryPage());
            Pages.Add(new BibilographyPage());
        }
    }
}
