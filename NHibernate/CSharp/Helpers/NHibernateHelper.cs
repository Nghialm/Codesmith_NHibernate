using System;
using System.ComponentModel;
using System.Data;
using System.Collections.Generic;
using System.Text;

using CodeSmith.Engine;
using SchemaExplorer;

public enum NHibernateVersion
{
	v1_2,
	v2_0
}
public enum VisualStudioVersion
{
	VS_2005,
	VS_2008
}

public class NHibernateHelper : CodeTemplate
{
	public string GetCriterionNamespace(NHibernateVersion version)
	{
		switch(version)
		{
			case NHibernateVersion.v1_2:
				return "NHibernate.Expression";
					
			case NHibernateVersion.v2_0:
				return "NHibernate.Criterion";
				
			default:
				throw new Exception("Invalid NHibernateVersion");
		}
	}
	
	#region Variable & Class Name Methods
    public string GetPropertyLeng(ColumnSchema column)
    {
        string tmpSize = "";
        string dbtype = column.DataType.ToString();
        switch (dbtype)
        {
            case "String":
                tmpSize="length=\"" + column.Size.ToString() + "\"";
                break;
            case "Decimal":
                tmpSize= string.Format("precision=\"{0}\" scale=\"{1}\"", column.Precision , column.Scale);
                break;
            default:
                tmpSize="";
                break;
                
        }
            
        return tmpSize;
    }
	
	public string GetPropertyName(TableSchema table, ColumnSchema column)
	{
		if(ColumnHasAlias(column))
			return GetPropertyName(GetNameFromColumn(column));
		else
			return GetPropertyName(GetClassName(table));
	}
	public string GetPropertyName(ColumnSchema column)
	{
		return GetPropertyName(GetNameFromColumn(column));
	}
	private string GetPropertyName(string name)
	{
		//return StringUtil.ToSingular(StringUtil.ToPascalCase(name));
		return GetCustomNameColumn(name);
	}
	
	public string GetPropertyNamePlural(TableSchema table, ColumnSchema column)
	{
		if(ColumnHasAlias(column))
			return GetPropertyNamePlural(GetNameFromColumn(column));
		else
			return GetPropertyNamePlural(GetClassName(table));
	}
	public string GetPropertyNamePlural(ColumnSchema column)
	{
		return GetPropertyNamePlural(GetNameFromColumn(column));
	}
	private string GetPropertyNamePlural(string name)
	{
		return StringUtil.ToPlural(StringUtil.ToPascalCase(name));
	}
	
	public string GetPrivateVariableName(TableSchema table, ColumnSchema column)
	{
		if(ColumnHasAlias(column))
			return GetPrivateVariableName(GetNameFromColumn(column));
		else
			return GetPrivateVariableName(GetClassName(table));
	}
	public string GetPrivateVariableName(ColumnSchema column)
	{
		return GetPrivateVariableName(GetNameFromColumn(column));
	}
	private string GetPrivateVariableName(string name)
	{
		return "_" + GetVariableName(name);
	}
	
	public string GetPrivateVariableNamePlural(TableSchema table, ColumnSchema column)
	{
		if(ColumnHasAlias(column))
			return GetPrivateVariableNamePlural(GetNameFromColumn(column));
		else
			return GetPrivateVariableNamePlural(GetClassName(table));
	}
	public string GetPrivateVariableNamePlural(ColumnSchema column)
	{
		return GetPrivateVariableNamePlural(GetNameFromColumn(column));
	}
	private string GetPrivateVariableNamePlural(string name)
	{
		return "_" + GetVariableNamePlural(name);
	}
	
	public string GetVariableName(TableSchema table, ColumnSchema column)
	{
		if(ColumnHasAlias(column))
			return GetVariableName(GetNameFromColumn(column));
		else
			return GetVariableName(GetClassName(table));
	}
	public string GetVariableName(ColumnSchema column)
	{
		return GetVariableName(GetNameFromColumn(column));
	}
	private string GetVariableName(string name)
	{
		//return StringUtil.ToSingular(StringUtil.ToCamelCase(name));
		return GetCustomNameColumn(name);
	}
	
	public string GetVariableNamePlural(TableSchema table, ColumnSchema column)
	{
		if(ColumnHasAlias(column))
			return GetVariableNamePlural(GetNameFromColumn(column));
		else
			return GetVariableNamePlural(GetClassName(table));
	}
	public string GetVariableNamePlural(ColumnSchema column)
	{
		return GetVariableNamePlural(GetNameFromColumn(column));
	}
	private string GetVariableNamePlural(string name)
	{
		return StringUtil.ToPlural(StringUtil.ToCamelCase(name));
	}
	
	public string GetClassName(TableSchema table)
	{
		string className;
		if(table.ExtendedProperties.Contains(extendedPropertyName))
			className = table.ExtendedProperties[extendedPropertyName].Value.ToString();
		else
		{
			className = table.Name;
			
			if (!String.IsNullOrEmpty(tablePrefix) && className.StartsWith(tablePrefix))
            	className = className.Remove(0, tablePrefix.Length);
		}

		//return StringUtil.ToSingular(StringUtil.ToPascalCase(className));
		//return GetCustomNameColumn(className);
        return table.Name;
	}
	protected string tablePrefix = String.Empty;
	
	private bool ColumnHasAlias(ColumnSchema column)
	{
		return column.ExtendedProperties.Contains(extendedPropertyName);
	}
	private string GetNameFromColumn(ColumnSchema column)
	{
		//return ColumnHasAlias(column) ? column.ExtendedProperties[extendedPropertyName].Value.ToString() : column.Name;
		return ColumnHasAlias(column) ? GetCustomNameColumn(column.Name) : column.Name;
	}
	
	private string GetCustomNameColumn(String columnname)
	{
		String SName = "";
        String s = columnname;
        String[] s_1;
        s_1= s.Split('_');
        if (!s.Contains("_"))
        for (int i = 0; i < s_1.Length; i++ )
        {
            String s_First = "";
            String s_Another = s_1[i];
            s_First = s_1[i][0].ToString().ToUpper();
            s_Another = s_1[i].ToLower();
            SName += s_First + s_Another.Remove(0, 1);
            }
        else
            SName = columnname;
            
        return SName;
		}
	
	private const string extendedPropertyName = "cs_alias";
	
	#endregion
	
	#region ManyToMany Table Methods
	
	public TableSchema GetToManyTable(TableSchema manyToTable, TableSchema sourceTable)
	{
		TableSchema result = null;
		foreach(TableKeySchema key in manyToTable.ForeignKeys)
			if(!key.PrimaryKeyTable.Equals(sourceTable))
			{
				result = key.PrimaryKeyTable;
				break;
			}
		return result;
	}
	public static MemberColumnSchema GetToManyTableKey(TableSchema manyToTable, TableSchema foreignTable)
    {
        MemberColumnSchema result = null;
        foreach (TableKeySchema key in manyToTable.ForeignKeys)
            if (key.PrimaryKeyTable.Equals(foreignTable))
            {
                result = key.ForeignKeyMemberColumns[0];
                break;
            }
        return result;
    }
	public bool IsManyToMany(TableSchema table)
	{
		// If there are 2 ForeignKeyColumns AND...
		// ...there are only two columns OR
		//    there are 3 columns and 1 is a primary key.
		return (table.ForeignKeyColumns.Count == 2
			&& ((table.Columns.Count == 2)
				|| (table.Columns.Count == 3 && table.PrimaryKey != null)));
	}
	
	#endregion
	
	public string GetCascade(MemberColumnSchema column)
	{
		return column.AllowDBNull ? "all" : "all-delete-orphan";
	}
	
	#region BusinessObject Methods
	
	public string GetInitialization(Type type)
	{
		string result;
		
		if(type.Equals(typeof(String)))
			result = "VBMSDefaultValue.DefaultString()";
		else if(type.Equals(typeof(DateTime)))
			result = "new DateTime()";
		else if(type.Equals(typeof(Decimal)))
			result = "0";
		else if(type.Equals(typeof(Guid)))
			result = "new Guid()";
		else if(type.Equals(typeof(Int32)))
			result = "0";
		else if(type.Equals(typeof(Byte)))
			result = "0";
		else if(type.IsPrimitive)
			result = String.Format("default({0})", type.Name.ToString());	
		else
			result = "null";
		return result;
	}
	public Type GetBusinessBaseIdType(TableSchema table)
	{
		if(IsMutliColumnPrimaryKey(table.PrimaryKey))
			return typeof(string);
		else
			return GetPrimaryKeyColumn(table.PrimaryKey).SystemType;
	}
	
	#endregion
	
	#region PrimaryKey Methods
	
	public MemberColumnSchema GetPrimaryKeyColumn(PrimaryKeySchema primaryKey)
	{
		if(primaryKey.MemberColumns.Count != 1)
			throw new System.ApplicationException("This method will only work on primary keys with exactly one member column.");
		return primaryKey.MemberColumns[0];
	}
	public bool IsMutliColumnPrimaryKey(PrimaryKeySchema primaryKey)
	{
		if(primaryKey.MemberColumns.Count == 0)
			throw new System.ApplicationException("This template will only work on primary keys with exactly one member column.");
			
		return (primaryKey.MemberColumns.Count > 1);
	}
	public string GetForeignKeyColumnClassName(MemberColumnSchema mcs, TableSchema table)
	{
		string result = String.Empty;
		foreach(TableKeySchema tks in table.ForeignKeys)
			if(tks.ForeignKeyMemberColumns.Contains(mcs))
			{
				result = GetPropertyName(tks.PrimaryKeyTable.Name);
				break;
			}
		return result;
	}

	#endregion
	
	#region Method Creation Methods
	
	public string GetMethodParameters(List<MemberColumnSchema> mcsList, bool isDeclaration)
	{
		StringBuilder result = new StringBuilder();
		bool isFirst = true;
		foreach(MemberColumnSchema mcs in mcsList)
		{
			if(isFirst)
				isFirst = false;
			else
				result.Append(", ");
			if(isDeclaration)
			{
				result.Append(mcs.SystemType.ToString());
				result.Append(" ");
			}
			result.Append(GetVariableName(mcs));
		}
		return result.ToString();
	}
	public string GetMethodParameters(MemberColumnSchemaCollection mcsc, bool isDeclaration)
	{
		List<MemberColumnSchema> mcsList = new List<MemberColumnSchema>();
        for (int x = 0; x < mcsc.Count; x++)
            mcsList.Add(mcsc[x]);
        return GetMethodParameters(mcsList, isDeclaration);
	}
	public string GetMethodDeclaration(SearchCriteria sc)
	{
		StringBuilder result = new StringBuilder();
		result.Append(sc.MethodName);
		result.Append("(");
		result.Append(GetMethodParameters(sc.Items, true));
		result.Append(")");
		return result.ToString();
	}
	public string GetPrimaryKeyCallParameters(List<MemberColumnSchema> mcsList)
	{
		System.Text.StringBuilder result = new System.Text.StringBuilder();
		for(int x=0; x<mcsList.Count; x++)
		{
			if(x>0)
				result.Append(", ");
			result.Append(String.Format("{0}.Parse(keys[{1}])", mcsList[x].SystemType, x));
		}
		return result.ToString();
	}
	
	#endregion
	
	public TableSchema GetForeignTable(MemberColumnSchema mcs, TableSchema table)
	{
		foreach(TableKeySchema tks in table.ForeignKeys)
			if(tks.ForeignKeyMemberColumns.Contains(mcs))
				return tks.PrimaryKeyTable;
		throw new Exception(String.Format("Could not find Column {0} in Table {1}'s ForeignKeys.", mcs.Name, table.Name));
	}
	
	protected Random random = new Random();
	public string GetUnitTestInitialization(ColumnSchema column)
	{
		string result;
		
		if(column.SystemType.Equals(typeof(String)))
		{
			StringBuilder sb = new StringBuilder();
			
            int size = (column.Size > 0 && column.Size < 100) ? random.Next(1, column.Size) : 10;
			
			sb.Append("\"");
			for(int x=0; x<size; x++)
			{
				switch(x % 5)
				{
					case 0:
						sb.Append("T");
						break;
					case 1:
						sb.Append("e");
						break;
					case 2:
						sb.Append("s");
						break;
					case 3:
						sb.Append("t");
						break;
					case 4:
						sb.Append(" ");
						break;
				}
			}
			sb.Append("\"");
			
			result = sb.ToString();
		}
		else if(column.SystemType.Equals(typeof(DateTime)))
			result = "DateTime.Now";
		else if(column.SystemType.Equals(typeof(Decimal)))
			result = Convert.ToDecimal(random.Next(1, 100)).ToString();
		else if(column.SystemType.Equals(typeof(Int32)))
			result = random.Next(1, 100).ToString();
		else if(column.SystemType.Equals(typeof(Boolean)))
			result = (random.Next(1, 2).Equals(1)).ToString().ToLower();
		else if(column.SystemType.IsPrimitive)
			result = String.Format("default({0})", column.SystemType.Name.ToString());
		else
			result = "null";
		
		return result;
	}
	
	public bool ContainsForeignKey(SearchCriteria sc, TableSchemaCollection tsc)
    {
        foreach (TableSchema ts in tsc)
            foreach (TableKeySchema tks in ts.PrimaryKeys)
                foreach (MemberColumnSchema mcs in sc.Items)
                    if (tks.PrimaryKeyMemberColumns.Contains(mcs))
                        return true;
        return false;
    }
}

#region SearchCriteria Class

public class SearchCriteria
{
    #region Static Content

    public static List<SearchCriteria> GetAllSearchCriteria(TableSchema table, string extendedProperty)
    {
        TableSearchCriteria tsc = new TableSearchCriteria(table, extendedProperty);
        return tsc.GetAllSearchCriteria();
    }
    public static List<SearchCriteria> GetAllSearchCriteria(TableSchema table)
    {
        TableSearchCriteria tsc = new TableSearchCriteria(table);
        return tsc.GetAllSearchCriteria();
    }

    public static List<SearchCriteria> GetPrimaryKeySearchCriteria(TableSchema table, string extendedProperty)
    {
        TableSearchCriteria tsc = new TableSearchCriteria(table, extendedProperty);
        return tsc.GetPrimaryKeySearchCriteria();
    }
    public static List<SearchCriteria> GetPrimaryKeySearchCriteria(TableSchema table)
    {
        TableSearchCriteria tsc = new TableSearchCriteria(table);
        return tsc.GetPrimaryKeySearchCriteria();
    }

    public static List<SearchCriteria> GetForeignKeySearchCriteria(TableSchema table, string extendedProperty)
    {
        TableSearchCriteria tsc = new TableSearchCriteria(table, extendedProperty);
        return tsc.GetForeignKeySearchCriteria();
    }
    public static List<SearchCriteria> GetForeignKeySearchCriteria(TableSchema table)
    {
        TableSearchCriteria tsc = new TableSearchCriteria(table);
        return tsc.GetForeignKeySearchCriteria();
    }

    public static List<SearchCriteria> GetIndexSearchCriteria(TableSchema table, string extendedProperty)
    {
        TableSearchCriteria tsc = new TableSearchCriteria(table, extendedProperty);
        return tsc.GetIndexSearchCriteria();
    }
    public static List<SearchCriteria> GetIndexSearchCriteria(TableSchema table)
    {
        TableSearchCriteria tsc = new TableSearchCriteria(table);
        return tsc.GetIndexSearchCriteria();
    }

    #endregion

    #region Declarations

    protected List<MemberColumnSchema> mcsList;
    protected MethodNameGenerationMode methodNameGenerationMode = MethodNameGenerationMode.Default;
    protected string methodName = String.Empty;
	protected string extendedProperty;

    #endregion

    #region Constructors

    protected SearchCriteria(string extendedProperty)
    {
		this.extendedProperty = extendedProperty;
        mcsList = new List<MemberColumnSchema>();
    }
    protected SearchCriteria(string extendedProperty, List<MemberColumnSchema> mcsList)
    {
		this.extendedProperty = extendedProperty;
        this.mcsList = mcsList;
    }

    #endregion

    #region Methods

    /// <summary>
    /// Sets MethodName to default generation: "GetBy{0}{1}{n}"
    /// </summary>
    public void SetMethodNameGeneration()
    {
        methodNameGenerationMode = MethodNameGenerationMode.Default;

        GenerateMethodName("GetBy", String.Empty, String.Empty);
    }
    /// <summary>
    /// Sets MethodName to be value of the specified Extended Property from the database.
    /// </summary>
    /// <param name="extendedProperty">Value of the Extended Property.</param>
    public void SetMethodNameGeneration(string extendedProperty)
    {
        methodNameGenerationMode = MethodNameGenerationMode.ExtendedProperty;

        methodName = extendedProperty;
    }
    /// <summary>
    /// Sets MethodName to custom generation: "{prefix}{0}{delimeter}{1}{suffix}"
    /// </summary>
    /// <param name="prefix">Method Prefix</param>
    /// <param name="delimeter">Column Delimeter</param>
    /// <param name="suffix">Method Suffix</param>
    public void SetMethodNameGeneration(string prefix, string delimeter, string suffix)
    {
        methodNameGenerationMode = MethodNameGenerationMode.Custom;

        GenerateMethodName(prefix, delimeter, suffix);
    }

    public override string ToString()
    {
        if (String.IsNullOrEmpty(methodName))
            SetMethodNameGeneration();

        return methodName;
    }

    protected void Add(MemberColumnSchema item)
    {
        mcsList.Add(item);
    }
    protected void GenerateMethodName(string prefix, string delimeter, string suffix)
    {
        StringBuilder sb = new StringBuilder();
        bool isFirst = true;

        sb.Append(prefix);
        foreach (MemberColumnSchema mcs in mcsList)
        {
            if (isFirst)
                isFirst = false;
            else
                sb.Append(delimeter);
			
			if(mcs.ExtendedProperties.Contains(extendedProperty))
				sb.Append(mcs.ExtendedProperties[extendedProperty].Value.ToString());
			else
            	sb.Append(mcs.Name);
        }
        sb.Append(suffix);

        methodName = sb.ToString();
    }
    
    #endregion

    #region Properties

	public bool IsAllUnique
    {
        get
        {
            bool result = false;
            foreach (MemberColumnSchema msc in mcsList)
                if (msc.IsUnique)
                {
                    result = true;
                    break;
                }
            return result;
        }
    }
	public List<MemberColumnSchema> Items
    {
        get { return mcsList; }
    }
    public bool IsAllPrimaryKeys
    {
        get
        {
            bool result = true;
            foreach (MemberColumnSchema msc in mcsList)
                if (!msc.IsPrimaryKeyMember)
                {
                    result = false;
                    break;
                }
            return result;
        }
    }
    public string MethodName
    {
        get { return this.ToString(); }
    }
    public MethodNameGenerationMode MethodNameGeneration
    {
        get { return methodNameGenerationMode; }
    }

    protected string Key
    {
        get
        {
            StringBuilder sb = new StringBuilder();

            foreach (MemberColumnSchema mcs in mcsList)
                sb.Append(mcs.Name);

            return sb.ToString();
        }
    }

    #endregion

    #region Enums & Classes

    public enum MethodNameGenerationMode
    {
        Default,
        ExtendedProperty,
        Custom
    }

    internal class TableSearchCriteria
    {
        #region Declarations

        protected TableSchema table;
        protected string extendedProperty = String.Empty;
		protected const string defaultExtendedProperty = "cs_alias";

        #endregion

        #region Constructor

        public TableSearchCriteria(TableSchema sourceTable)
        {
            this.table = sourceTable;
        }
        public TableSearchCriteria(TableSchema sourceTable, string extendedProperty) : this(sourceTable)
        {
            this.extendedProperty = extendedProperty;
        }

        #endregion

        #region Methods

        public List<SearchCriteria> GetAllSearchCriteria()
        {
            Dictionary<string, SearchCriteria> map = new Dictionary<string, SearchCriteria>();

            GetPrimaryKeySearchCriteria(map);
            GetForeignKeySearchCriteria(map);
            GetIndexSearchCriteria(map);

            return GetResultsFromMap(map);
        }
        public List<SearchCriteria> GetPrimaryKeySearchCriteria()
        {
            Dictionary<string, SearchCriteria> map = new Dictionary<string, SearchCriteria>();

            GetPrimaryKeySearchCriteria(map);

            return GetResultsFromMap(map);
        }
        public List<SearchCriteria> GetForeignKeySearchCriteria()
        {
            Dictionary<string, SearchCriteria> map = new Dictionary<string, SearchCriteria>();

            GetForeignKeySearchCriteria(map);

            return GetResultsFromMap(map);
        }
        public List<SearchCriteria> GetIndexSearchCriteria()
        {
            Dictionary<string, SearchCriteria> map = new Dictionary<string, SearchCriteria>();

            GetIndexSearchCriteria(map);

            return GetResultsFromMap(map);
        }

        protected void GetPrimaryKeySearchCriteria(Dictionary<string, SearchCriteria> map)
        {
            List<MemberColumnSchema> mcsList = new List<MemberColumnSchema>(table.PrimaryKey.MemberColumns.ToArray());
            SearchCriteria searchCriteria = new SearchCriteria(ExtendedProperty, mcsList);

            if (table.PrimaryKey.ExtendedProperties.Contains(ExtendedProperty))
                if (!String.IsNullOrEmpty(ExtendedProperty) && table.PrimaryKey.ExtendedProperties.Contains(ExtendedProperty) && table.PrimaryKey.ExtendedProperties[ExtendedProperty].Value != null)
                    searchCriteria.SetMethodNameGeneration(table.PrimaryKey.ExtendedProperties[ExtendedProperty].Value.ToString());

            AddToMap(map, searchCriteria);
        }
        protected void GetForeignKeySearchCriteria(Dictionary<string, SearchCriteria> map)
        {
            foreach (TableKeySchema tks in table.ForeignKeys)
            {
                SearchCriteria searchCriteria = new SearchCriteria(ExtendedProperty);
                foreach (MemberColumnSchema mcs in tks.ForeignKeyMemberColumns)
                    if (mcs.Table.Equals(table))
                        searchCriteria.Add(mcs);

                if (!String.IsNullOrEmpty(ExtendedProperty) && tks.ExtendedProperties.Contains(ExtendedProperty) && tks.ExtendedProperties[ExtendedProperty].Value != null)
                    searchCriteria.SetMethodNameGeneration(tks.ExtendedProperties[ExtendedProperty].Value.ToString());

                AddToMap(map, searchCriteria);
            }
        }
        protected void GetIndexSearchCriteria(Dictionary<string, SearchCriteria> map)
        {
            foreach (IndexSchema indexSchema in table.Indexes)
            {
                SearchCriteria searchCriteria = new SearchCriteria(ExtendedProperty);
                foreach (MemberColumnSchema mcs in indexSchema.MemberColumns)
                    if (mcs.Table.Equals(table))
                        searchCriteria.Add(mcs);

                if (!String.IsNullOrEmpty(ExtendedProperty) && indexSchema.ExtendedProperties.Contains(ExtendedProperty) && indexSchema.ExtendedProperties[ExtendedProperty].Value != null)
                    searchCriteria.SetMethodNameGeneration(indexSchema.ExtendedProperties[ExtendedProperty].Value.ToString());

                AddToMap(map, searchCriteria);
            }
        }

        protected bool AddToMap(Dictionary<string, SearchCriteria> map, SearchCriteria searchCriteria)
        {
            string key = searchCriteria.Key;
            bool result = (searchCriteria.Items.Count > 0 && !map.ContainsKey(key));

            if (result)
                map.Add(key, searchCriteria);

            return result;
        }
        protected List<SearchCriteria> GetResultsFromMap(Dictionary<string, SearchCriteria> map)
        {
            List<SearchCriteria> result = new List<SearchCriteria>();
            foreach (KeyValuePair<string, SearchCriteria> kvp in map)
            {
                result.Add(kvp.Value);
            }
            return result;
        }

        #endregion

        #region Properties

		public string ExtendedProperty
		{
			get { return (String.IsNullOrEmpty(extendedProperty)) ? defaultExtendedProperty : extendedProperty; }
		}
        public TableSchema Table
        {
            get { return table; }
        }

        #endregion
    }

    #endregion
}

#endregion