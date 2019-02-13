table 50100 DataToBC
{
    DataClassification = ToBeClassified;

    fields
    {
        field(1; "Entry No."; Integer)
        {
            DataClassification = ToBeClassified;
            AutoIncrement = true;
        }

        field(2; MyField1; Text[250])
        {
            DataClassification = ToBeClassified;

        }

        field(3; MyField2; Text[250])
        {
            DataClassification = ToBeClassified;

        }

        field(4; MyField3; Text[250])
        {
            DataClassification = ToBeClassified;

        }

        field(5; MyField4; Text[250])
        {
            DataClassification = ToBeClassified;

        }

        field(6; MyField5; Text[250])
        {
            DataClassification = ToBeClassified;

        }

        field(7; MyField6; Text[250])
        {
            DataClassification = ToBeClassified;

        }

        field(8; MyField7; Text[250])
        {
            DataClassification = ToBeClassified;

        }

        field(9; MyField8; Text[250])
        {
            DataClassification = ToBeClassified;

        }

        field(10; MyField9; Text[250])
        {
            DataClassification = ToBeClassified;

        }

        field(11; MyField10; Text[250])
        {
            DataClassification = ToBeClassified;

        }

        field(12; MyField11; Text[250])
        {
            DataClassification = ToBeClassified;

        }

        field(13; MyField12; Text[250])
        {
            DataClassification = ToBeClassified;

        }

        field(14; MyField13; Text[250])
        {
            DataClassification = ToBeClassified;

        }

        field(15; MyField14; Text[250])
        {
            DataClassification = ToBeClassified;

        }

        field(16; MyField15; Text[250])
        {
            DataClassification = ToBeClassified;

        }

        field(17; MyField16; Text[250])
        {
            DataClassification = ToBeClassified;

        }

        field(18; MyField17; Text[250])
        {
            DataClassification = ToBeClassified;

        }

        field(19; MyField18; Text[250])
        {
            DataClassification = ToBeClassified;

        }

        field(20; MyField19; Text[250])
        {
            DataClassification = ToBeClassified;

        }

        field(21; MyField20; Text[250])
        {
            DataClassification = ToBeClassified;

        }

        field(22; MyField21; Text[250])
        {
            DataClassification = ToBeClassified;

        }

        field(23; MyField22; Text[250])
        {
            DataClassification = ToBeClassified;

        }

        field(24; MyField23; Text[250])
        {
            DataClassification = ToBeClassified;

        }

        field(25; MyField24; Text[250])
        {
            DataClassification = ToBeClassified;

        }

        field(26; MyField25; Text[250])
        {
            DataClassification = ToBeClassified;

        }

        field(27; MyField26; Text[250])
        {
            DataClassification = ToBeClassified;

        }

        field(28; MyField27; Text[250])
        {
            DataClassification = ToBeClassified;

        }

        field(29; MyField28; Text[250])
        {
            DataClassification = ToBeClassified;

        }

        field(30; MyField29; Text[250])
        {
            DataClassification = ToBeClassified;

        }
        field(31; MyField30; Text[250])
        {
            DataClassification = ToBeClassified;

        }
        field(32; MyField31; Text[250])
        {
            DataClassification = ToBeClassified;

        }
        field(33; MyField32; Text[250])
        {
            DataClassification = ToBeClassified;

        }
        field(34; MyField33; Text[250])
        {
            DataClassification = ToBeClassified;

        }
        field(35; MyField34; Text[250])
        {
            DataClassification = ToBeClassified;

        }
        field(36; MyField35; Text[250])
        {
            DataClassification = ToBeClassified;

        }
        field(37; MyField36; Text[250])
        {
            DataClassification = ToBeClassified;

        }
        field(38; MyField37; Text[250])
        {
            DataClassification = ToBeClassified;

        }
        field(39; MyField38; Text[250])
        {
            DataClassification = ToBeClassified;

        }

        field(40; Type; Option)
        {
            DataClassification = ToBeClassified;
            OptionMembers = Customer,Item,Vendor;
        }

    }

    keys
    {
        key(PK; "Entry No.")
        {
            Clustered = true;
        }
    }


    trigger OnInsert()
    begin

    end;

    trigger OnModify()
    begin

    end;

    trigger OnDelete()
    begin

    end;

    trigger OnRename()
    begin

    end;

}