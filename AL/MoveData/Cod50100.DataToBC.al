codeunit 50100 DataToBC
{
    trigger OnRun()
    begin

    end;

    procedure Create(Type: Text; JsonString: Text; DirectCreate: boolean)
    begin
        case Type of
            'Customers':
                CreateCustomer(JsonString, DirectCreate);
            'Items':
                CreateItems(JsonString, DirectCreate);
            'Vendors':
                CreateVendor(JsonString, DirectCreate);
        end;
    end;

    procedure GetFunctions(): Text
    begin
        EXIT('Customers,Items,Vendors');
    end;

    procedure GetFields(Type: Text; Direct: Boolean): Text
    begin
        if Direct then begin
            case Type of
                'Customers':
                    if Direct then
                        EXIT('No,Name,Name2,Address,Address2,City,PostCode');
                'Items':
                    EXIT('No,Description,Description2');
                'Vendors':
                    EXIT('No,Name,Name2,Address,Address2,City,PostCode');
                else
                    EXIT('Not Vaild')
            end;
        end else
            EXIT('MyField1,MyField2,MyField3,MyField4,MyField5,MyField6,MyField7,MyField8,MyField9,MyField10,MyField11,MyField12,MyField13,MyField14,MyField15,MyFiel' +
                          'd16,MyField17,MyField18,MyField19,MyField20,MyField21,MyField22,MyField23,MyField24,MyField25,MyField26,MyField27,MyField28,MyField29,MyField30');
    end;

    local procedure CreateCustomer(jsonString: Text; DirectCreate: boolean)
    var
        Customer: record Customer;
        dataToBc: Record DataToBC;
        JsonToken: JsonToken;
        JsonValue: JsonValue;
        JsonObject: JsonObject;
        JsonArray: JsonArray;
        i: Integer;
    begin
        JsonArray.ReadFrom(jsonString);
        Customer.Init();
        dataToBc.Init();

        for i := 0 to JsonArray.Count() - 1 do begin
            JsonArray.Get(i, JsonToken);

            JsonObject := JsonToken.AsObject();
            if DirectCreate then begin
                case GetJsonToken(JsonObject, 'field').AsValue().AsText() of
                    'No':
                        Customer.Validate("No.", GetJsonToken(JsonObject, 'value').AsValue().AsCode());
                    'Name':
                        Customer.Validate(Name, GetJsonToken(JsonObject, 'value').AsValue().AsText());
                    'Name2':
                        Customer.Validate("Name 2", GetJsonToken(JsonObject, 'value').AsValue().AsText());
                    'Address':
                        Customer.Validate(Address, GetJsonToken(JsonObject, 'value').AsValue().AsText());
                    'Address2':
                        Customer.Validate("Address 2", GetJsonToken(JsonObject, 'value').AsValue().AsText());
                    'City':
                        Customer.Validate(City, GetJsonToken(JsonObject, 'value').AsValue().AsText());
                    'PostCode':
                        Customer.Validate("Post Code", GetJsonToken(JsonObject, 'value').AsValue().AsText());
                    'InsertTrigger':
                        Customer.Insert(true);
                end;
            end else
                CreateNotDirect(JsonObject, 0);

        end;
    end;

    local procedure CreateVendor(jsonString: Text; DirectCreate: boolean)
    var
        Vendor: record Vendor;
        dataToBc: Record DataToBC;
        JsonToken: JsonToken;
        JsonValue: JsonValue;
        JsonObject: JsonObject;
        JsonArray: JsonArray;
        i: Integer;
    begin
        JsonArray.ReadFrom(jsonString);
        Vendor.Init();
        dataToBc.Init();

        for i := 0 to JsonArray.Count() - 1 do begin
            JsonArray.Get(i, JsonToken);

            JsonObject := JsonToken.AsObject();
            if DirectCreate then begin
                case GetJsonToken(JsonObject, 'field').AsValue().AsText() of
                    'No':
                        Vendor.Validate("No.", GetJsonToken(JsonObject, 'value').AsValue().AsCode());
                    'Name':
                        Vendor.Validate(Name, GetJsonToken(JsonObject, 'value').AsValue().AsText());
                    'Name2':
                        Vendor.Validate("Name 2", GetJsonToken(JsonObject, 'value').AsValue().AsText());
                    'Address':
                        Vendor.Validate(Address, GetJsonToken(JsonObject, 'value').AsValue().AsText());
                    'Address2':
                        Vendor.Validate("Address 2", GetJsonToken(JsonObject, 'value').AsValue().AsText());
                    'City':
                        Vendor.Validate(City, GetJsonToken(JsonObject, 'value').AsValue().AsText());
                    'PostCode':
                        Vendor.Validate("Post Code", GetJsonToken(JsonObject, 'value').AsValue().AsText());
                    'InsertTrigger':
                        Vendor.Insert(true);
                end;
            end else
                CreateNotDirect(JsonObject, 2);

        end;
    end;

    local procedure CreateItems(jsonString: Text; DirectCreate: boolean)
    var
        Item: record Item;
        JsonToken: JsonToken;
        JsonValue: JsonValue;
        JsonObject: JsonObject;
        JsonArray: JsonArray;
        i: Integer;
    begin
        JsonArray.ReadFrom(jsonString);
        Item.Init();
        for i := 0 to JsonArray.Count() - 1 do begin
            JsonArray.Get(i, JsonToken);

            JsonObject := JsonToken.AsObject();
            if DirectCreate then begin
                case GetJsonToken(JsonObject, 'field').AsValue().AsText() of
                    'No':
                        Item.Validate("No.", GetJsonToken(JsonObject, 'value').AsValue().AsCode());
                    'Description':
                        Item.Validate(Description, GetJsonToken(JsonObject, 'value').AsValue().AsText());
                    'Description2':
                        Item.Validate("Description 2", GetJsonToken(JsonObject, 'value').AsValue().AsText());
                    'InsertTrigger':
                        Item.Insert(true);
                end;
            end else
                CreateNotDirect(JsonObject, 1);

        end;
    end;

    local procedure GetJsonToken(JsonObject: JsonObject; TokenKey: Text) JsonToken: JsonToken;
    begin
        JsonObject.Get(TokenKey, JsonToken);
    end;

    local procedure CreateNotDirect(JsonObject: JsonObject; type: Integer)
    begin
        case GetJsonToken(JsonObject, 'field').AsValue().AsText() of
            'MyField1':
                dataToBc.Validate(dataToBc.MyField1, GetJsonToken(JsonObject, 'value').AsValue().AsText());
            'MyField2':
                dataToBc.Validate(dataToBc.MyField2, GetJsonToken(JsonObject, 'value').AsValue().AsText());
            'MyField3':
                dataToBc.Validate(dataToBc.MyField3, GetJsonToken(JsonObject, 'value').AsValue().AsText());
            'MyField4':
                dataToBc.Validate(dataToBc.MyField4, GetJsonToken(JsonObject, 'value').AsValue().AsText());
            'MyField5':
                dataToBc.Validate(dataToBc.MyField5, GetJsonToken(JsonObject, 'value').AsValue().AsText());
            'MyField6':
                dataToBc.Validate(dataToBc.MyField6, GetJsonToken(JsonObject, 'value').AsValue().AsText());
            'MyField7':
                dataToBc.Validate(dataToBc.MyField7, GetJsonToken(JsonObject, 'value').AsValue().AsText());
            'MyField8':
                dataToBc.Validate(dataToBc.MyField8, GetJsonToken(JsonObject, 'value').AsValue().AsText());
            'MyField9':
                dataToBc.Validate(dataToBc.MyField9, GetJsonToken(JsonObject, 'value').AsValue().AsText());
            'MyField10':
                dataToBc.Validate(dataToBc.MyField10, GetJsonToken(JsonObject, 'value').AsValue().AsText());
            'MyField11':
                dataToBc.Validate(dataToBc.MyField11, GetJsonToken(JsonObject, 'value').AsValue().AsText());
            'MyField12':
                dataToBc.Validate(dataToBc.MyField12, GetJsonToken(JsonObject, 'value').AsValue().AsText());
            'MyField13':
                dataToBc.Validate(dataToBc.MyField13, GetJsonToken(JsonObject, 'value').AsValue().AsText());
            'MyField14':
                dataToBc.Validate(dataToBc.MyField14, GetJsonToken(JsonObject, 'value').AsValue().AsText());
            'MyField15':
                dataToBc.Validate(dataToBc.MyField15, GetJsonToken(JsonObject, 'value').AsValue().AsText());
            'MyField16':
                dataToBc.Validate(dataToBc.MyField16, GetJsonToken(JsonObject, 'value').AsValue().AsText());
            'MyField17':
                dataToBc.Validate(dataToBc.MyField17, GetJsonToken(JsonObject, 'value').AsValue().AsText());
            'MyField18':
                dataToBc.Validate(dataToBc.MyField18, GetJsonToken(JsonObject, 'value').AsValue().AsText());
            'MyField19':
                dataToBc.Validate(dataToBc.MyField19, GetJsonToken(JsonObject, 'value').AsValue().AsText());
            'MyField20':
                dataToBc.Validate(dataToBc.MyField20, GetJsonToken(JsonObject, 'value').AsValue().AsText());
            'MyField21':
                dataToBc.Validate(dataToBc.MyField21, GetJsonToken(JsonObject, 'value').AsValue().AsText());
            'MyField22':
                dataToBc.Validate(dataToBc.MyField22, GetJsonToken(JsonObject, 'value').AsValue().AsText());
            'MyField23':
                dataToBc.Validate(dataToBc.MyField23, GetJsonToken(JsonObject, 'value').AsValue().AsText());
            'MyField24':
                dataToBc.Validate(dataToBc.MyField24, GetJsonToken(JsonObject, 'value').AsValue().AsText());
            'MyField25':
                dataToBc.Validate(dataToBc.MyField25, GetJsonToken(JsonObject, 'value').AsValue().AsText());
            'MyField26':
                dataToBc.Validate(dataToBc.MyField26, GetJsonToken(JsonObject, 'value').AsValue().AsText());
            'MyField27':
                dataToBc.Validate(dataToBc.MyField27, GetJsonToken(JsonObject, 'value').AsValue().AsText());
            'MyField28':
                dataToBc.Validate(dataToBc.MyField28, GetJsonToken(JsonObject, 'value').AsValue().AsText());
            'MyField29':
                dataToBc.Validate(dataToBc.MyField29, GetJsonToken(JsonObject, 'value').AsValue().AsText());
            'MyField30':
                dataToBc.Validate(dataToBc.MyField30, GetJsonToken(JsonObject, 'value').AsValue().AsText());
            'MyField31':
                dataToBc.Validate(dataToBc.MyField31, GetJsonToken(JsonObject, 'value').AsValue().AsText());
            'MyField32':
                dataToBc.Validate(dataToBc.MyField32, GetJsonToken(JsonObject, 'value').AsValue().AsText());
            'MyField33':
                dataToBc.Validate(dataToBc.MyField33, GetJsonToken(JsonObject, 'value').AsValue().AsText());
            'MyField34':
                dataToBc.Validate(dataToBc.MyField34, GetJsonToken(JsonObject, 'value').AsValue().AsText());
            'MyField35':
                dataToBc.Validate(dataToBc.MyField35, GetJsonToken(JsonObject, 'value').AsValue().AsText());
            'MyField36':
                dataToBc.Validate(dataToBc.MyField36, GetJsonToken(JsonObject, 'value').AsValue().AsText());
            'MyField37':
                dataToBc.Validate(dataToBc.MyField37, GetJsonToken(JsonObject, 'value').AsValue().AsText());
            'MyField38':
                dataToBc.Validate(dataToBc.MyField38, GetJsonToken(JsonObject, 'value').AsValue().AsText());
            'InsertTrigger':
                begin
                    dataToBc."Entry No." := 0;
                    dataToBc.Type := type;
                    dataToBc.Insert();
                end;
        end;
    end;

    var
        dataToBc: Record DataToBC;
}