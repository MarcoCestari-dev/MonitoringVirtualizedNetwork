docker run -it --rm -v /var/run/docker.sock:/var/run/docker.sock gaiaadm/pumba netem --interface eth0 --duration 1m loss-gemodel -p 40 -r 60 --one-h 62 --one-k 38 HostC

Commento: Aumentiamo momentaneamente il rate di perdita a fini di diminuire la lunghezza del video.
Comando Originale: "docker run -it --rm -v /var/run/docker.sock:/var/run/docker.sock gaiaadm/pumba netem --interface eth0 --duration 1m loss-gemodel -p 3 -r 97 --one-h 98 --one-k 2 HostC"