FROM node:latest As builder

WORKDIR /home/app/

COPY . /home/app/

RUN npm install

EXPOSE 4200

CMD npm run start
