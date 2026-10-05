<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="2.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
  xmlns:xslt="http://xml.apache.org/xslt" xmlns:s0="http://reqm.sw.ecu.bosch.com"
  xmlns="http://www.asam.net/schemas/issue/issue300" exclude-result-prefixes="s0 xslt">
	<xsl:output omit-xml-declaration="no" method="xml" version="1.0"
	  encoding="utf-8" xslt:indent-amount="4" indent="yes"/>

	<xsl:template name="setShortName">
		<xsl:param name="asamFile" select="''"/>
		<xsl:param name="externalId" />
		<xsl:param name="state" />
		<xsl:param name="creationDate" />
		<SHORT-NAME>
			<xsl:choose>
				<xsl:when test="$asamFile = ''">
					<xsl:value-of select="concat($externalId, '_', $state, '_',
            translate(translate($creationDate, '-: ', ''), 'T', '_'), '.xml')"/>
				</xsl:when>
				<xsl:otherwise>
					<xsl:value-of select="$asamFile" />
				</xsl:otherwise>
			</xsl:choose>
		</SHORT-NAME>
	</xsl:template>

	<xsl:template name="addTeamMember">
		<xsl:param name="id" select="''"/>
		<xsl:param name="shortName" />
		<xsl:param name="longName" />
		<xsl:param name="email" select="''"/>
		<xsl:param name="externalId" select="''"/>
		<xsl:param name="roleIds" />

		<TEAM-MEMBER>
			<xsl:if test="$id != ''">
				<xsl:attribute name="ID" select="$id"/>
			</xsl:if>
			<SHORT-NAME>
				<xsl:value-of select="$shortName" />
			</SHORT-NAME>
			<LONG-NAME>
				<xsl:value-of select="$longName" />
			</LONG-NAME>
			<ROLES>
				<ROLE>
					<xsl:choose>
						<xsl:when test="string-length($externalId) &lt; 7">
							<xsl:value-of select="substring-before($roleIds, '|')" />
						</xsl:when>
						<xsl:otherwise>
							<xsl:value-of select="substring-after($roleIds, '|')" />
						</xsl:otherwise>
					</xsl:choose>
				</ROLE>
			</ROLES>
			<xsl:if test="$email != ''">
				<EMAIL>
					<xsl:value-of select="$email" />
				</EMAIL>
			</xsl:if>
		</TEAM-MEMBER>
	</xsl:template>

	<xsl:template name="setCategory">
		<xsl:param name="externalId" />
		<xsl:if test="string-length($externalId) &gt;= 7">
			<xsl:text>CRANE/MSG</xsl:text>
		</xsl:if>
	</xsl:template>
</xsl:stylesheet>