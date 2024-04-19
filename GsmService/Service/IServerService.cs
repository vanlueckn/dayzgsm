﻿using System.Net;
using GsmCore.Model;

namespace GsmApi.Service;

public interface IServerService
{
    public Task<Server> CreateServer(string name, IPAddress bindIp, uint gamePort, uint queryPort, uint slots = 32);

    public Task StartServer(Server server);

    public Task StopServer(Server server);

    public Task RestartServer(Server server);

    public Task UpdateServer(Server server);

    public Task DeleteServer(Server server);

    public Task UpdateNetworking(Server server, IPAddress bindIp, uint gamePort, uint queryPort, uint rconPort,
        bool restart = false);

    public Task UpdateFlags(Server server, bool autoStart, bool autoRestart, bool autoUpdate, bool doLogs,
        bool adminLog, bool netLog);

    public Task UpdateGameData(Server server, string name, uint slots, string map, string rconPassword,
        string additionalStartParams);

    public int GetProcessForServer(int serverId);
}