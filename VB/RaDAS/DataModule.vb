Module DataModule
    Public numberOfIntervals As Integer = 5     ' Equal to number of sensors less one
    Public COMPort As String

    ' Data arrays
    Public timeCounts(numberOfIntervals) As Integer     '
    Public secs(numberOfIntervals) As Double            '
    Public secs_sum(numberOfIntervals) As Double        '
    Public lenghts(numberOfIntervals) As Double         '
    Public velocities(numberOfIntervals) As Double      '

    Public OutputFile(numberOfIntervals) As String
    Public FilePath As String
    Public FileName As String
    Public chartType As String = "Points"
    Public decimalDigits As Integer = 3
    Public unitNmb As Integer = 1
    Public units As Array = {{"Meters [m]", "Centimeters [cm]", "Millimeters [mm]"}, {"m", "cm", "mm"}, {1, 10, 1000}}
    Public mesureUnit As String = "Centimeters [cm]"
    Public railLenght As Double = 200
    Public segmentsReference As String = "Relative"     ' Can be "Absolute" or "Relative"
End Module
