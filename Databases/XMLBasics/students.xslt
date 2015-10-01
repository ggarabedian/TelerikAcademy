<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:template match="/">
        
        <html>
            <head>
                <title>Students</title>
                <style>
                    ul{
                    padding-left: 10px;
                    list-style-type: none;
                    }
                    li{
                    margin: 5px;
                    }
                    ul ul li{
                    display: inline;
                    }
                    p{
                    font-weight: bold;
                    }
                </style>
            </head>
            <body>
                <h1>Students</h1>
                <ul>
                    <xsl:for-each select="/students/student">
                        <p>Student Information</p>
                        <li>
                            Name: <xsl:value-of select="name"/>
                        </li>
                        <li>
                            Sex: <xsl:value-of select="sex"/>
                        </li>
                        <li>
                            Birth Date: <xsl:value-of select="birthDate"/>
                        </li>
                        <li>
                            Phone Number: <xsl:value-of select="phone"/>
                        </li>
                        <li>
                            E-mail: <xsl:value-of select="email"/>
                        </li>
                        <li>
                            Course: <xsl:value-of select="course"/>
                        </li>
                        <li>
                            Specialty: <xsl:value-of select="specialty"/>
                        </li>
                        <li>
                            Faculty Number: <xsl:value-of select="facultyNumber"/>
                        </li>
                        <p>Enrollement Information</p>
                        <li>
                            Date: <xsl:value-of select="enrollmentInfo/date"/>
                        </li>
                        <li>
                            Score: <xsl:value-of select="enrollmentInfo/score"/>
                        </li>
                        <p>Exams Information</p>
                            <ul>
                                <xsl:for-each select="exams/exam">
                                    <li>
                                        <xsl:value-of select="name"/>
                                    </li>
                                    <li>
                                        Tutor: <xsl:value-of select="tutor"/>
                                    </li>
                                    <li>
                                        Score: <xsl:value-of select="score"/>
                                    </li>
                                    <br/>
                                </xsl:for-each>
                            </ul>
                        <hr/>
                    </xsl:for-each>
                </ul>
            </body>
        </html>
    </xsl:template>
</xsl:stylesheet>
