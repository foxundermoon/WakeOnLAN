﻿'    WakeOnLAN - Wake On LAN
'    Copyright (C) 2004-2013 Aquila Technology, LLC. <webmaster@aquilatech.com>
'
'    This file is part of WakeOnLAN.
'
'    WakeOnLAN is free software: you can redistribute it and/or modify
'    it under the terms of the GNU General Public License as published by
'    the Free Software Foundation, either version 3 of the License, or
'    (at your option) any later version.
'
'    WakeOnLAN is distributed in the hope that it will be useful,
'    but WITHOUT ANY WARRANTY; without even the implied warranty of
'    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'    GNU General Public License for more details.
'
'    You should have received a copy of the GNU General Public License
'    along with WakeOnLAN.  If not, see <http://www.gnu.org/licenses/>.

Public NotInheritable Class SplashScreen

    Private Sub SplashScreen_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        Me.Dispose()
    End Sub

    Private Sub SplashScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ApplicationTitle.Text = My.Resources.Strings.Title
        Version.Text = System.String.Format(My.Resources.Strings.Version, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)
        Copyright.Text = My.Application.Info.Copyright

#If DEBUG Then
        'Timer1.Interval = 1000
#End If
        Me.Show()
        Application.DoEvents()
        'Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Dispose()
    End Sub

End Class
