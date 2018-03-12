require 'json'


MyApp.add_route('GET', '/Afulki9/GetQuotes/1.0.0/inventory', {
  "resourcePath" => "/Developers",
  "summary" => "searches inventory",
  "nickname" => "search_inventory", 
  "responseClass" => "array[QuoteUnion]", 
  "endpoint" => "/inventory", 
  "notes" => "By passing in the appropriate options, you can search for available inventory in the system ",
  "parameters" => [
    {
      "name" => "search_string",
      "description" => "pass an optional search string for looking up inventory",
      "dataType" => "string",
      "paramType" => "query",
      
      "allowableValues" => "",
      
    },
    {
      "name" => "skip",
      "description" => "number of records to skip for pagination",
      "dataType" => "int",
      "paramType" => "query",
      
      "allowableValues" => "",
      
    },
    {
      "name" => "limit",
      "description" => "maximum number of records to return",
      "dataType" => "int",
      "paramType" => "query",
      
      "allowableValues" => "",
      
    },
    ]}) do
  cross_origin
  # the guts live here

  {"message" => "yes, it worked"}.to_json
end

