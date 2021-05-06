docker run -it --rm -v /var/run/docker.sock:/var/run/docker.sock gaiaadm/pumba netem --interface eth0 --duration 1m loss-state -p13 40 -p31 20 -p32 30 p23 30 p14 40 HostB

Commento: Aumentiamo momentaneamente il rate di perdita a fini di diminuire la lunghezza del video.
Comando Originale: "docker run -it --rm -v /var/run/docker.sock:/var/run/docker.sock gaiaadm/pumba netem --interface eth0 --duration 1m loss-state -p13 2 -p31 80 -p32 12 p23 5 p14 11 HostB"
pause