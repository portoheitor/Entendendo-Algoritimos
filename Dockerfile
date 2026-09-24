FROM mcr.microsoft.com/dotnet/sdk:10.0

RUN apt-get update && apt-get install -y \
    git \
    curl \
    sqlite3 \
    && rm -rf /var/lib/apt/lists/*

# Instala o GitHub CLI
RUN (type -p wget >/dev/null || (apt-get update && apt-get install wget -y)) \
    && mkdir -p -m 755 /etc/apt/keyrings \
    && wget -qO- https://cli.github.com/packages/githubcli-archive-keyring.gpg | tee /etc/apt/keyrings/githubcli-archive-keyring.gpg > /dev/null \
    && chmod go+r /etc/apt/keyrings/githubcli-archive-keyring.gpg \
    && echo "deb [arch=$(dpkg --print-architecture) signed-by=/etc/apt/keyrings/githubcli-archive-keyring.gpg] https://cli.github.com/packages stable main" | tee /etc/apt/sources.list.d/github-cli.list > /dev/null \
    && apt-get update \
    && apt-get install gh -y

RUN dotnet tool install --global dotnet-ef --version 10.0.0
ENV PATH="${PATH}:/root/.dotnet/tools"

WORKDIR /workspace