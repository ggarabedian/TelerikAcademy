<?xml version="1.0" encoding="utf-8"?>

<xsl:stylesheet version="1.0"
  xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

    <xsl:output method='html' version='1.0' encoding='UTF-8' indent='yes' />

    <xsl:template match="/">
        <xsl:text disable-output-escaping="yes">&lt;!DOCTYPE html&gt;
</xsl:text>
        <html>
            <style>
                ul{
                    list-style-type: none;
                }
            </style>
            <body>
                <h2>Albums Collection</h2>
                <table border="1">
                    <tr bgcolor="#CCCCCC">
                        <th align="center">Album Name</th>
                        <th align="center">Artist</th>
                        <th align="center">Year</th>
                        <th align="center">Producer</th>
                        <th align="center">Price</th>
                        <th align="center">Songs</th>
                    </tr>
                    <xsl:for-each select="catalogue/album">
                        <tr>
                            <td>
                                <xsl:value-of select="name"/>
                            </td>
                            <td>
                                <xsl:value-of select="artist"/>
                            </td>
                            <td>
                                <xsl:value-of select="year"/>
                            </td>
                            <td>
                                <xsl:value-of select="producer"/>
                            </td>
                            <td>
                                <xsl:value-of select="price"/>
                            </td>
                            <td>
                                <ul>
                                    <xsl:for-each select="songs/song">
                                        <li>
                                            <xsl:value-of select="title"/>
                                            &#160;&#160;&#160;&#160;
                                            <xsl:value-of select="duration"/>s
                                        </li>
                                    </xsl:for-each>
                                </ul>
                            </td>
                        </tr>
                    </xsl:for-each>
                </table>
            </body>
        </html>
    </xsl:template>

</xsl:stylesheet>