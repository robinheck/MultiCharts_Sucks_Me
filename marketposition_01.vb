Var:EntryCount(0);

if date<>date[1] then begin
	EntryCount=0;
end;

if marketposition<>marketposition[1] then begin
	EntryCount=EntryCount+1;
	Print("marketposition_",marketposition);
end;

if EntryCount=0 then begin
	if c cross over average(C,20)+30 then begin
		buy next bar at market;
	end;
	if c cross under average(C,20)-30 then begin
		sellshort next bar at market;
	end;
end;
