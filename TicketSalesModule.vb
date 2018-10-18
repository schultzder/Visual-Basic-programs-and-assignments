Module TicketSalesModule

    ' This module contains the CalcTax function.

    Const sngTAXRATE As Single = 0.06       ' Sales Tax Rate

    Public Function CalcTax(ByVal cost As Decimal) As Decimal

        ' This function calculates and returns the
        ' sales tax on ticket sales. The ticket cost is
        ' passed as an argument.
        Return cost * sngTAXRATE
    End Function

End Module
