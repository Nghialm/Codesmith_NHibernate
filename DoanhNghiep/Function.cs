//-------------------------------------------------------------
// CodeSmith DBDocumenter Templates v3.0
// Author:  Nghialm
//-------------------------------------------------------------

using System;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;
using System.ComponentModel.Design;
using CodeSmith.Engine;
using SchemaExplorer;

public class Function : CodeTemplate
{
	public string _dic = "E:\\CodeGen\\DoanhNghiep\\";
	
	public Function() : base()
	{
	}
	
	public string GenNameSpace(string _tablename)
	{
		string s = _tablename;
		if (s.IndexOf("ht_") == 0) return ".Hethong";
		if (s.IndexOf("sp_") == 0) return ".Sanpham";
		if (s.IndexOf("dm") == 0) return ".Dictionary";
		if (s.IndexOf("cv_") == 0) return ".Congviec";
		if (s.IndexOf("qt_") == 0) return ".Quytrinh";
		//if (s.IndexOf("ct") == 0) return ".Accouting";
		//if (s.IndexOf("giaidoan") == 0) return ".Invitation";
		//if (s.IndexOf("S_") == 0 || s.IndexOf("s_") == 0) return ".Admin";
		return "";
		}
		
	//Return Column type C#		
	public string ConvertDBType2CSType(ColumnSchema tempCol1)
	{
		string s = "";
		switch (tempCol1.DataType)
		{
			case DbType.Guid:
				s = "Guid";
				break;
			case DbType.Int16:
				s = "Int16";			
				break;
			case DbType.Int32:
				s = "Int32";
				break;
			case DbType.Int64:
				s = "Int64";
				break;
			default:
				s = "String";
				break;
		}
		return s;
	}	
	
	public string EntityClassName(string _tablename)
	{
		string stable = _tablename;
		return stable;
		}
	}