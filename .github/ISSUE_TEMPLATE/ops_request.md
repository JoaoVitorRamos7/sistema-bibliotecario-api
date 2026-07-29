---
name: Operational Request
about: >
    Commits relacionados a pipelines de deploy, infraestrutura, monitoramento, backups e tarefas operacionais, como provisionamento de servidores e configuração de ambientes.
title: '[ops]:'
labels: ['operational']
assignees: []
---
## Resumo

Automatizar os backups do banco de dados para o S3 todas as noites à meia-noite.

## Tarefas

- [ ] Criar script de backup
- [ ] Agendar tarefa no cron
- [ ] Configurar credenciais da AWS no CI/CD
- [ ] Testar a restauração a partir do backup

## Motivação

Melhorar a preparação para recuperação de desastres.