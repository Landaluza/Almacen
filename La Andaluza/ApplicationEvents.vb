Namespace My

    ' The following events are available for MyApplication:
    ' 
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a Double-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
        Public Shadows Sub Startup() Handles MyBase.Startup
            If Not My.Computer.Network.IsAvailable Then
                MessageBox.Show("No dispone de conexión de red. No será posible utilizar la aplicacion", "Sin conexión", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Environment.Exit(1)
            End If
        End Sub
    End Class


End Namespace

