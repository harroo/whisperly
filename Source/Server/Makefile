#used to build the server in this location

#old:
#mcs Source/*/*.cs -out:Server.cil

output:
	find Source/ | grep .cs | xargs mcs -out:Output/Server.cil

prep:
	mkdir Output/
	echo "cd Output;mono Server.cil;cd .." >> test.sh
	chmod 755 test.sh

run:
	./test.sh
