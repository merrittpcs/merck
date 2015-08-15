
		var currentSearchTerm = "";
		//var searchTerm = "new";
		function InsertSearchTerm(searchTerm, imgURL, slideNum)
		{ 
		  if (currentSearchTerm != searchTerm) 
		  {
		   	 currentSearchTerm = searchTerm;
			 var adOpenKeySet = 1;
			 var searchTermCount = 0;
			 var connection = new ActiveXObject("ADODB.Connection");
			 var connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='DemoFDAProposal.accdb'; Persist Security Info=False";
			 connection.Open(connectionstring);
			 var rs = new ActiveXObject("ADODB.Recordset");
			 var rsSearchCount = new ActiveXObject("ADODB.Recordset");
			 rs.Open("INSERT INTO tblSearchTerms ( SearchTerm ) SELECT '" + searchTerm + "'",connection);
			 
			 rsSearchCount.Open("Select Count(SearchTerm) from tblSearchTerms where SearchTerm = '" + searchTerm + "'",connection, adOpenKeySet);
			 searchTermCount = rsSearchCount(0);
			 //alert("Searchterm Added Successfuly. \n\n The search term {" + searchTerm + "} has been searched on " + searchTermCount + " times.");
			 connection.close();
		  }
			 
			 var connection = new ActiveXObject("ADODB.Connection");
			 var connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='DemoFDAProposal.accdb'; Persist Security Info=False";
		  connection.Open(connectionstring);
		  var rs = new ActiveXObject("ADODB.Recordset");
		  var rsSearchCount = new ActiveXObject("ADODB.Recordset");
		  rs.Open("INSERT INTO tblSlidesClicked ( SlideNumber ) SELECT " + slideNum + "",connection);
		  connection.close();

		  //alert(imgURL);
		  popitup(imgURL);

		}
		function popitup(url) 
		{
			newwindow=window.open(url,'name','height=600,width=800');
			if (window.focus)
			{
				newwindow.focus();
			}
			//alert("PopItUp");
			return false;
		}


