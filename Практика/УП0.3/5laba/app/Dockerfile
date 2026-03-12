FROM python:3.12-slim-bookworm
COPY ./requirements.txt /app/requirements.txt
WORKDIR /app
RUN pip install -r requirements.txt
# highlight-start
RUN mkdir -p /app/log
COPY app.py /app
# highlight-end
EXPOSE 5000
CMD ["python", "app.py" ]
