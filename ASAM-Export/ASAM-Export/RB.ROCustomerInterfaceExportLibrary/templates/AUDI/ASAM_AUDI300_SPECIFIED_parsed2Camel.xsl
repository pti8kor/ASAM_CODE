<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
  xmlns:xslt="http://xml.apache.org/xslt" xmlns:s0="http://reqm.sw.ecu.bosch.com"
  xmlns="http://www.asam.net/schemas/issue/issue300"
  exclude-result-prefixes="s0 xslt" version="1.0">
  <xsl:output omit-xml-declaration="no" method="xml" version="1.0"
    encoding="utf-8" xslt:indent-amount="4" indent="yes" />

  <xsl:param name="ASAMFileName"/>

  <xsl:include href="ASAM_Templates.xsl"/>

  <xsl:template match="/RQ1_EXTRACT">
    <MSR-ISSUE xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
      xmlns="http://www.asam.net/schemas/issue/issue300"
      xsi:schemaLocation="http://www.asam.net/schemas/issue/issue300 issue_v3_0_0.sl.xsd">

      <xsl:variable name="IssueExternalId">
        <xsl:choose>
          <xsl:when test="contains(//Issues/Issue/External_ID,'sub')">
            <xsl:value-of select="substring-before(substring-after(//Issues/Issue/External_ID,'sub('),')')" />
          </xsl:when>
          <xsl:otherwise>
            <xsl:value-of select="//Issues/Issue/External_ID" />
          </xsl:otherwise>
        </xsl:choose>
      </xsl:variable>

      <xsl:call-template name="setShortName">
        <xsl:with-param name="asamFile" select="$ASAMFileName"/>
        <xsl:with-param name="externalId" select="$IssueExternalId"/>
        <xsl:with-param name="state" select="'SPECIFIED'"/>
        <xsl:with-param name="creationDate" select="./@CreationDate"/>
      </xsl:call-template>
      <CATEGORY>
        <xsl:call-template name="setCategory">
          <xsl:with-param name="externalId" select="$IssueExternalId"/>
        </xsl:call-template>
      </CATEGORY>
      <COMPANY-DATAS>
        <xsl:variable name="IssueExtSubmitterDbid" select="//Issues/Issue/ExternalSubmitter" />
        <xsl:variable name="IssueExtAssigneeDbid" select="//Issues/Issue/ExternalAssignee" />

        <COMPANY-DATA>
          <SHORT-NAME>
            <xsl:value-of select="//Issues/Issue/ExternalOrganisation" />
          </SHORT-NAME>
          <TEAM-MEMBERS>
            <xsl:call-template name="addTeamMember">
              <xsl:with-param name="id" select="'C1_TM1'"/>
              <xsl:with-param name="shortName" select="//Contacts/Contact[@dbid=$IssueExtSubmitterDbid]/FirstName"/>
              <xsl:with-param name="longName" select="//Contacts/Contact[@dbid=$IssueExtSubmitterDbid]/LastName"/>
              <xsl:with-param name="externalId" select="$IssueExternalId"/>
              <xsl:with-param name="roleIds" select="'Ersteller|Change Responsible'"/>
            </xsl:call-template>
            <xsl:call-template name="addTeamMember">
              <xsl:with-param name="id" select="'C1_TM2'"/>
              <xsl:with-param name="shortName" select="//Contacts/Contact[@dbid=$IssueExtAssigneeDbid]/FirstName"/>
              <xsl:with-param name="longName" select="//Contacts/Contact[@dbid=$IssueExtAssigneeDbid]/LastName"/>
              <xsl:with-param name="externalId" select="$IssueExternalId"/>
              <xsl:with-param name="roleIds" select="'Aenderungsspezifikateur|Specifier'"/>
            </xsl:call-template>
          </TEAM-MEMBERS>
        </COMPANY-DATA>
        <COMPANY-DATA>
          <SHORT-NAME>
            <xsl:text>Bosch</xsl:text>
          </SHORT-NAME>
        </COMPANY-DATA>
      </COMPANY-DATAS>
      <ADMIN-DATA>
        <DOC-REVISIONS>
          <DOC-REVISION>
            <TEAM-MEMBER-REF ID-REF="C1_TM1" />
            <DATE>
              <xsl:value-of select="/s0:RQ1_EXTRACT/@CreationDate" />
            </DATE>
          </DOC-REVISION>
        </DOC-REVISIONS>
      </ADMIN-DATA>
      <ISSUES>
        <ISSUE>
          <SHORT-NAME>
            <xsl:value-of select="$IssueExternalId" />
          </SHORT-NAME>
          <LONG-NAME>
            <xsl:value-of select="//Issues/Issue/ExternalTitle" />
          </LONG-NAME>
          <CATEGORY>
            <xsl:attribute name="SI">
              <xsl:choose>
                <xsl:when test="//Issues/Issue/Domain = 'Hardware'">
                  <xsl:text>HARDWARE</xsl:text>
                </xsl:when>
                <xsl:when test="contains(//Issues/Issue/ExternalExchangeWorkflow,'PRA')">
                  <xsl:text>PROCESS</xsl:text>
                </xsl:when>
                <xsl:otherwise>
                  <xsl:text>SOFTWARE</xsl:text>
                </xsl:otherwise>
              </xsl:choose>
            </xsl:attribute>
            <xsl:text>CHANGE-REQUEST</xsl:text>
          </CATEGORY>
          <ISSUE-DESC />
          <COMPANY-ISSUE-INFOS>
            <COMPANY-ISSUE-INFO>
              <COMPANY-DATA-REF>
                <xsl:value-of select="//Issues/Issue/ExternalOrganisation" />
              </COMPANY-DATA-REF>
              <ISSUE-ID>
                <xsl:value-of select="$IssueExternalId" />
              </ISSUE-ID>
              <PROJECT-ID />
              <TEAM-MEMBER-REF ID-REF="C1_TM2" />
              <TRANSACTION-ID />
            </COMPANY-ISSUE-INFO>
            <COMPANY-ISSUE-INFO>
              <COMPANY-DATA-REF>
                <xsl:text>Bosch</xsl:text>
              </COMPANY-DATA-REF>
              <ISSUE-ID>
                <xsl:choose>
                  <xsl:when test="contains(//Issues/Issue/Tags,'&lt;ASAMSupplierNumber&gt;')">
                    <xsl:for-each select="//Issues/Issue/Tags/p[contains(.,'&lt;ASAMSupplierNumber&gt;')]">
                      <xsl:value-of select="substring-before(substring-after(.,'&lt;ASAMSupplierNumber&gt;'),'&lt;/ASAMSupplierNumber&gt;')" />
                    </xsl:for-each>
                  </xsl:when>
                  <xsl:otherwise>
                    <xsl:value-of select="//Issues/Issue/id" />
                  </xsl:otherwise>
                </xsl:choose>
              </ISSUE-ID>
              <PROJECT-ID />
              <TEAM-MEMBER-REF ID-REF="C1_TM2" />
              <TRANSACTION-ID />
            </COMPANY-ISSUE-INFO>
          </COMPANY-ISSUE-INFOS>
          <ISSUE-PROPERTIES>
            <ISSUE-CURRENT-STATE>
              <DATE>
                <xsl:value-of select="/s0:RQ1_EXTRACT/@CreationDate" />
              </DATE>
              <TEAM-MEMBER-REF />
              <ISSUE-STATE>
                <xsl:text>SPECIFIED</xsl:text>
              </ISSUE-STATE>
            </ISSUE-CURRENT-STATE>
            <ISSUE-PRIORITY>
              <xsl:text>TOP</xsl:text>
            </ISSUE-PRIORITY>
            <ISSUE-SEVERITY>
              <xsl:text>TOP</xsl:text>
            </ISSUE-SEVERITY>
          </ISSUE-PROPERTIES>
          <ISSUE-SOLUTIONS>
            <ISSUE-SOLUTION>
              <CATEGORY SI=""></CATEGORY>
              <xsl:if test="//Issues/Issue/hasAttachmentMappings/* and count(//AttachmentMappings/AttachmentMapping[ExportState = 'SPECIFIED'])&gt;0">
                <ISSUE-RELATED-DOCUMENTS>
                  <xsl:for-each select="//Issues/Issue/hasAttachmentMappings/dbid">
                    <xsl:variable name="AttMapDbid" select="." />
                    <xsl:choose>
                      <xsl:when test="(//AttachmentMappings/AttachmentMapping[@dbid=$AttMapDbid]/ExportState = 'SPECIFIED') and contains(//AttachmentMappings/AttachmentMapping[@dbid=$AttMapDbid]/Attribute,'technical')">
                        <ISSUE-RELATED-DOCUMENT SI="technical">
                          <LABEL>
                            <xsl:value-of select="concat($IssueExternalId,'_')" />
                            <xsl:value-of select="//AttachmentMappings/AttachmentMapping[@dbid=$AttMapDbid]/Eng_Attachment" />
                          </LABEL>
                          <URL>
                            <xsl:value-of select="concat($IssueExternalId,'_')" />
                            <xsl:value-of select="//AttachmentMappings/AttachmentMapping[@dbid=$AttMapDbid]/Eng_Attachment" />
                          </URL>
                        </ISSUE-RELATED-DOCUMENT>
                      </xsl:when>
                      <xsl:otherwise>
                      </xsl:otherwise>
                    </xsl:choose>
                  </xsl:for-each>
                </ISSUE-RELATED-DOCUMENTS>
              </xsl:if>
            </ISSUE-SOLUTION>
          </ISSUE-SOLUTIONS>
          <ISSUE-HISTORY-STATES>
            <ISSUE-HISTORY-STATE>
              <TEAM-MEMBER-REF />
              <ISSUE-STATE>
                <xsl:choose>
                  <xsl:when test="//Issues/Issue/ExternalState_Parallel1 = 'ESTIMATED-PI' or //Issues/Issue/ExternalState_Parallel1 = 'ESTIMATED-OF'">
                    <xsl:text>ESTIMATED</xsl:text>
                  </xsl:when>
                  <xsl:when test="contains(//Issues/Issue/ExternalState_Parallel1,'ACCEPTED')">
                    <xsl:text>ACCEPTED</xsl:text>
                  </xsl:when>
                  <xsl:when test="contains(//Issues/Issue/ExternalState_Parallel1,'REJECTED')">
                    <xsl:text>REJECTED</xsl:text>
                  </xsl:when>
                  <xsl:otherwise>
                    <xsl:value-of select="//Issues/Issue/ExternalState_Parallel1" />
                  </xsl:otherwise>
                </xsl:choose>
              </ISSUE-STATE>
            </ISSUE-HISTORY-STATE>
          </ISSUE-HISTORY-STATES>
          <ISSUE-ANNOTATIONS>
            <ISSUE-ANNOTATION SI="specified_technical_note">
              <TEAM-MEMBER-REF />
              <ANNOTATION-TEXT>
                <P>X</P>
              </ANNOTATION-TEXT>
            </ISSUE-ANNOTATION>
          </ISSUE-ANNOTATIONS>
        </ISSUE>
      </ISSUES>
    </MSR-ISSUE>
  </xsl:template>
</xsl:stylesheet>