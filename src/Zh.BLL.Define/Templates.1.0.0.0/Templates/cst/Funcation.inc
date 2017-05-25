<script runat="template">
    public string GetClassName(string defaultName)
    {
        if(!string.IsNullOrEmpty(this.ClassName)){
            return this.ClassName;
        }
        return defaultName; 
    } 
    public string GetTableName(){
        return SourceTable.Name;
    }
</script>
