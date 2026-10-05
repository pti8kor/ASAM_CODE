using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace RB.ROCustomerIntefaceLibrary
{
    /// <summary>
    /// ROIssue class holds the properties (fieldnames) of Issue recordtype in RequestOne
    /// </summary>
    public class ROIssue
    {
        #region "Properties"

        public string IssueDescription
        { get; set; }
        public string IssueTitle
        { get; set; }
        public string IssueROID
        { get; set; }
        public string IssueExternalID
        { get; set; }
        public string BelongsToProject
        { get; set; }
        public string IssueState
        { get; set; }
        public string ExternalTitle
        { get; set; }
        public string ExternalState
        { get; set; }
        public string ExternalComment
        { get; set; }
        public string ExternalSubmitter
        { get; set; }
        public string ExternalAssignee
        { get; set; }
        public string ExternalReveiew
        { get; set; }
        public string ExternalIssueDescription
        { get; set; }
        public string IssueSolutionDescription
        { get; set; }
        public string ExternalTags
        { get; set; }
        public string Release
        { get; set; }
        public string IssueDomain
        { get; set; }
        public string IssueType
        { get; set; }
        public string IssueScope
        { get; set; }
        #endregion
    }
    /// <summary>
    /// ROContact class holds the properties (fieldnames) of Contact recordtype in RequestOne
    /// </summary>
    public class ROContact
    {
        #region "Properties"
        public string ContactdbID
        { get; set; }
        public string FirstName
        { get; set; }
        public string LastName
        { get; set; }
        public string Company
        { get; set; }
        public string Department
        { get; set; }
        public string Email
        { get; set; }
        public string Phone
        { get; set; }
        public string Role
        { get; set; }
        #endregion
    }

    /// <summary>
    /// RORelease class holds the properties (fieldnames) of Release recordtype in RequestOne
    /// </summary>
    public class RORelease
    {
        #region "Properties"

        public string ReleaseID
        { get; set; }
        public string Title
        { get; set; }
        public string Domain
        { get; set; }
        public string Type
        { get; set; }
        public string Scope
        { get; set; }
        public string Category
        { get; set; }
        public string Classification
        { get; set; }
        public string Description
        { get; set; }
        public string PlannedDate
        { get; set; }
        public string ActualDate
        { get; set; }
        public string BelongsToProject
        { get; set; }
        public string Assignee
        { get; set; }
        public string State
        { get; set; }
        public string ExternalID
        { get; set; }
        public string ExternalTitle
        { get; set; }
        public string ExternalDescription
        { get; set; }
        public string ExternalComment
        { get; set; }
        public string ExternalSubmitter
        { get; set; }
        public string ExternalAssignee
        { get; set; }
        public string ExternalState
        { get; set; }

        #endregion

    }

    /// <summary>
    /// RORelease class holds the properties (fieldnames) of IssueReleaseMap recordtype in RequestOne
    /// </summary>
    public class ROIssueReleaseMap
    {
        #region "Properties"
        public string IRID
        { get; set; }
        public string Domain
        { get; set; }
        public string Scope
        { get; set; }
        public string LifeCycleState
        { get; set; }
        public string HasMappedIssue
        { get; set; }
        public string HasMappedRelease
        { get; set; }
        public string Description
        { get; set; }
        public string IsPilot
        { get; set; }
        public string LastMinuteChange
        { get; set; }
        public string LateChange
        { get; set; }


        #endregion

    }

    /// <summary>
    /// ROExchangeProtocol class holds the properties (fieldnames) of ExchangeProtocol recordtype in RequestOne
    /// </summary>
    public class ROExchangeProtocol
    {
        public string Name { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public string Log { get; set; }
        public ArrayList Files { get; set; }
        public DateTime Date { get; set; }
        public ArrayList ExchangedFiles { get; set; }
        public ArrayList ExchangedCommercialFiles { get; set; }

    }

    /// <summary>
    /// RoProject class holds the properties (fieldnames) of Project recordtype in RequestOne
    /// </summary>
    public class RoProject
    {
        public string ProjectID { get; set; }
        public string State { get; set; }
        public string ExternalState { get; set; }
        public ROExchangeProtocol hasExchangeProtocols { get; set; }
    }
}
