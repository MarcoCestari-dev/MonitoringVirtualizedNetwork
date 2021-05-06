docker run -it --rm -v /var/run/docker.sock:/var/run/docker.sock gaiaadm/pumba netem --interface eth0 --duration 1m loss --percent 40 HostA

Commento: Aumentiamo momentaneamente il rate di perdita al fine di diminuire la lunghezza del video.
Comando Originale: "docker run -it --rm -v /var/run/docker.sock:/var/run/docker.sock gaiaadm/pumba netem --interface eth0 --duration 1m loss --percent 3 HostA"