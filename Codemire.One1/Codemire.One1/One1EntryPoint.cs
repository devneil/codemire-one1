using System;

namespace Codemire.One1
{
    public class One1EntryPoint
    {
        private readonly IMeetingRepository _repository;

        public One1EntryPoint(IMeetingRepository repository)
        {
            _repository = repository;
        }

        public void RecordMeeting(Guid guid, string report, string meetingNotes)
        {
            
        }

        public void NewActionForReport(string report, string actionText, DateTime dueDate)
        {
            
        }

        public void NewActionForReport(string report, string actionText)
        {
            
        }

        public void NewActionForDelegate(string delegateTo, string actionText, DateTime dueDate)
        {
            
        }
        
        public void NewActionForDelegate(string delegateTo, string actionText)
        {
            
        }

        public void AddDiscussionPoint(string report, string discussionPoint)
        {
            
        }

        public string[] GetDiscussionPoints()
        {
            throw new NotImplementedException();
        }
    }

    public interface IMeetingRepository
    {
    }
}