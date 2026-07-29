---
name: Performance Request
about: Commits de refatoração focados em melhorar o desempenho do projeto.
title: '[perf]:'
labels: 'performance'
assignees: ''
---
## Resumo

Utilizar carregamento sob demanda e compressão nas imagens do banner da página inicial para melhorar o tempo de carregamento.

## Comportamento atual

As imagens são carregadas imediatamente, causando lentidão na renderização inicial.

## Plano de melhoria

- [ ] Habilitar carregamento sob demanda para imagens não críticas
- [ ] Comprimir as imagens usando WebP
- [ ] Testar a velocidade de carregamento antes e depois

## Métricas a acompanhar

- Pontuação de desempenho no Lighthouse
- Tempo de carregamento da página