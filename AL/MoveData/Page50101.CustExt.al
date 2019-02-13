pageextension 50101 CustomerExt extends "Customer List"
{
    layout
    {
        // Add changes to page layout here
    }

    actions
    {
        addlast(Creation)
        {
            group(MyActionGroup)
            {
                Action(MyAction1)
                {
                    ApplicationArea = All;
                    Caption = 'Delete ALL';

                    trigger OnAction();
                    var
                        Customer: Record Customer;
                    begin
                        Customer.DeleteAll();
                    end;
                }
            }
        }
    }

    var
        myInt: Integer;
}