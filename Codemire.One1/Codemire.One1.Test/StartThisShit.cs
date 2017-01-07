using System;
using FluentAssertions;
using NUnit.Framework;

namespace Codemire.One1.Test
{
    [TestFixture]
    public class StartThisShit
    {
        private One1EntryPoint _root;

        [SetUp]
        public void SetUp()
        {
            IMeetingRepository mockRepository = new MockRepository();
            _root = new One1EntryPoint(mockRepository);
        }

        [Test]
        public void CanInstantiateOneOnOne(){}

        [Test]
        public void CanCreateANewOneOnOneMeetingRecord()
        {
            _root.RecordMeeting(Guid.NewGuid(), "Lorenzo", "Silly pants");
        }

        [Test]
        public void CanCreateAnActionForReportWithDueDate()
        {
            _root.NewActionForReport("Lorenzo", "Wear new shirt tomorrow", DateTime.Now.AddDays(1));
        }

        [Test]
        public void CanCreateAnActionForReportWithNoDueDate()
        {
            _root.NewActionForReport("Natasha", "get to the shops and buy potatoes");
        }

        [Test]
        public void CanCreateAnActionForDelegateWithDueDate()
        {
            _root.NewActionForDelegate("Robyn", "Wear new shirt tomorrow", DateTime.Now.AddDays(1));
        }

        [Test]
        public void CanCreateAnActionForDelegateWithNoDueDate()
        {
            _root.NewActionForDelegate("James", "help me");
        }

        [Test]
        public void CanCreateDiscussionPointForNextMeeting()
        {
            _root.AddDiscussionPoint("Anthony", "Why you no wiggle?");
        }

        [Test]
        public void CanGetListOfAllDiscussionPoints()
        {

            _root.GetDiscussionPoints().Length.Should().Be(3);
        }


        public class MockRepository : IMeetingRepository
        {
            private string[] _discussionPoints;

            public void AddDiscussionPoints(string[] discussionPoints)
            {
                _discussionPoints = discussionPoints;
            }
        }
    }


}
