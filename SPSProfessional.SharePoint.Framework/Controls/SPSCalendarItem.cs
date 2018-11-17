using System;
using System.Xml.Serialization;
using Microsoft.SharePoint;

namespace SPSProfessional.SharePoint.Framework.Controls
{
    [Serializable]
    public class SPSCalendarItem
    {
        private DateTime _startDate;
        private DateTime _endDate;
        private Boolean _hasEndDate;
        private string _title;
        private string _displayFormUrl;
        private string _location;
        private string _description;
        private bool _isAllDayEvent;
        private bool _isRecurrence;
        private int _calendarType;
        private string _backgroundColorClassName;
        private string _itemID;

        #region Properties

        [XmlAttribute]
        public DateTime StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        [XmlAttribute]
        public DateTime EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }

        [XmlAttribute]
        public bool HasEndDate
        {
            get { return _hasEndDate; }
            set { _hasEndDate = value; }
        }

        [XmlAttribute]
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        [XmlAttribute]
        public string DisplayFormUrl
        {
            get { return _displayFormUrl; }
            set { _displayFormUrl = value; }
        }

        [XmlAttribute]
        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }

        [XmlAttribute]
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        [XmlAttribute]
        public bool IsAllDayEvent
        {
            get { return _isAllDayEvent; }
            set { _isAllDayEvent = value; }
        }

        [XmlAttribute]
        public bool IsRecurrence
        {
            get { return _isRecurrence; }
            set { _isRecurrence = value; }
        }

        [XmlAttribute]
        public int CalendarType
        {
            get { return _calendarType; }
            set { _calendarType = value; }
        }

        [XmlAttribute]
        public string BackgroundColorClassName
        {
            get { return _backgroundColorClassName; }
            set { _backgroundColorClassName = value; }
        }

        [XmlAttribute]
        public string ItemID
        {
            get { return _itemID; }
            set { _itemID = value; }
        }

        #endregion

        public SPSCalendarItem()
        {
            Title = string.Empty;
            Description = string.Empty;
            DisplayFormUrl = string.Empty;
            Location = string.Empty;
            CalendarType = SPContext.Current.RegionalSettings.CalendarType;
            BackgroundColorClassName = null;
        }
    }
}