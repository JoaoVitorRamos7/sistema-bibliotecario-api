---
name: Chore Request
about: >
    Commits diversos que não alteram código ou comportamento, focados na manutenção. Ex.: atualizar .gitignore, renomear configurações ou remover arquivos temporários.
title: '[chore]:'
labels: ['chore']
assignees: []
---
## Resumo

Atualizar o `.gitignore` para impedir que arquivos do sistema macOS sejam versionados.

## Motivação

Limpar o repositório e evitar que arquivos desnecessários poluam os diffs.

## Tarefas

- [ ] Adicionar `.DS_Store` ao `.gitignore`
- [ ] Remover arquivos `.DS_Store` existentes rastreados